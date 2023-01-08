using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptCalidad : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public int calidad;

    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 4);
        dropdown.value = calidad;
        AjustarCalidad();
    }


    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad = dropdown.value;
    }
}