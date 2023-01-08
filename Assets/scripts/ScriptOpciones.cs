using UnityEngine;

public class ScriptOpciones : MonoBehaviour
{

    public ControladorOpciones panelOpciones;

    void Start()
    {
        panelOpciones = GameObject.FindGameObjectWithTag("opciones").GetComponent<ControladorOpciones>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {

        }
    }

    public void MostrarOpciones()
    {
        panelOpciones.pantallaOpciones.SetActive(true);
    }
}
