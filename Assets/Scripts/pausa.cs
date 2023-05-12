using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausa : MonoBehaviour
{

    public GameObject imagen;
    public GameObject slider;
    private bool activado;
    // Start is called before the first frame update
    void Start()
    {
        activado = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            activado = !activado;
        }

        if(activado==true)
        {
            imagen.SetActive(true);
            slider.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            imagen.SetActive(false);
            slider.SetActive(true);
            Time.timeScale = 1;
        }
    }
}
