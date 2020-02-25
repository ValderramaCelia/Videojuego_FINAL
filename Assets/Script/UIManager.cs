using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public GameObject Opciones;


    public void AbrirOpciones()
    {
        if (Opciones.activeSelf)
        {
            Opciones.SetActive(false);
        }
        else
        {
            Opciones.SetActive(true);
        }
    }

    public void botonjugar()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void botonsalir()
    {
        Application.Quit();
    }


    // Start is called before the first frame update
    void Start()
    {
        AbrirOpciones();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
