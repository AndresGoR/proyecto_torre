using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 1f;
    private Rigidbody2D player;
    private Vector2 input;


    public bool sePuedeMover = true;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private Animator playerAnimator;

    [SerializeField] private Vector2 velocidadRebote;
    [SerializeField] private float velocidadEscalar;

    private CapsuleCollider2D capsuleCollider2D;
    private float gravedadInicial;
    private bool escalando;

    AudioSource audioSource;

    // Timer coyote time
    public float coyoteTime = 0.2f;
    private float coyoteTimer;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        gravedadInicial = player.gravityScale;
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(AnimacionInicio());
    }

    // Update is called once per frame
    void Update()
    {
     
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        //DIRECCIÓN DEL PERSONAJE//

        
            direction = Input.GetAxis("Horizontal");

        
            if (direction > 0f)
            {
                player.velocity = new Vector2(direction * speed, player.velocity.y);
                transform.localScale = new Vector2(1f, 1f);
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else if (direction < 0f)
            {
                player.velocity = new Vector2(direction * speed, player.velocity.y);
                transform.localScale = new Vector2(-1f, 1f);
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }
            else
            {
                player.velocity = new Vector2(0, player.velocity.y);
                audioSource.Stop();
            }


        //FIN DIRECCIÓN DEL PERSONAJE//


        //SALTO DE PERSONAJE//
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            
                coyoteTimer = coyoteTime;
           

            player.velocity = new Vector2(player.velocity.x, jumpSpeed); 
        }

        if (coyoteTimer > 0 && Input.GetButtonDown("Jump"))
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            coyoteTimer = 0;
        }

        coyoteTimer -= Time.deltaTime;
        //FIN SALTO DE PERSONAJE//

        //ANIMACIÓN DE PERSONAJE//
        playerAnimator.SetFloat("speed", Mathf.Abs(player.velocity.x));
        playerAnimator.SetBool("onGround", isTouchingGround);
        //FIN ANIMACIÓN DE PERSONAJE//


    }

    public IEnumerator AnimacionInicio()
    {
        yield return new WaitForSeconds(1f);
       
    }
}
