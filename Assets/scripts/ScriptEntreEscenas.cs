using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEntreEscenas : MonoBehaviour
{
    private void Awake()
    {
        
         var noDestruirEntreEscenas = FindObjectsOfType<ScriptEntreEscenas>();
            if(noDestruirEntreEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
