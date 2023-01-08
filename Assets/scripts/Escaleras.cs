using UnityEngine;

public class Escaleras : MonoBehaviour
{

    private float vertical;
    private float speed = 2f;
    private bool isLadder;
    private bool isClimbing;

    private Animator playerAnimator;


    [SerializeField] private Rigidbody2D rb;


    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }

        playerAnimator.SetBool("estaEscalando", isClimbing);
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Escaleras"))
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Escaleras"))
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}
