using UnityEngine;

public class ScriptGameOver : MonoBehaviour
{

    [SerializeField] private Vector3 posicion;
    // private Transform bruja;


    public GameObject GameOverMenuUI;
    public static bool GameIsPaused = false;

    private bool haPerdidoYa = false;

    private void Start()
    {
        //  bruja = this.gameObject.transform;
    }
    private void Update()
    {

        if (transform.position.y < posicion.y || haPerdidoYa)
        {
            return;
        }

        Pause();

    }


    void Pause()
    {
        GameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        haPerdidoYa = true;
    }

}
