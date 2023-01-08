using TMPro;
using UnityEngine;

public class ScriptYouWin : MonoBehaviour
{
    [SerializeField] private Vector3 posicion;
    // private Transform warrior;
    private float timerStart = 0;

    public TextMeshProUGUI timer;
    public GameObject YouWinUI;
    public static bool GameIsPaused = false;

    private bool haGanadoYa = false;



    private void Start()
    {
        //warrior = this.gameObject.transform;
    }
    private void Update()
    {
        timerStart += Time.deltaTime;
        timer.text = "" + timerStart.ToString("f1");

        if (transform.position.y < posicion.y || haGanadoYa)
        {
            return;
        }

        Pause();

    }

    void Pause()
    {
        YouWinUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        haGanadoYa = true;
    }


}
