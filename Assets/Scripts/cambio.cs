using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio : MonoBehaviour
{
    [SerializeField] private GameObject coyote;
    [SerializeField] private GameObject baquir;
    private GameObject actual;

    private bool cambiar=false;

    // Start is called before the first frame update
    void Start()
    {
        baquir.SetActive(false);
        actual = coyote;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(cambiar==false)
            {
                actual = coyote;
                coyote.SetActive(false);
                baquir.SetActive(true);
                baquir.transform.position = new Vector3(actual.transform.position.x, actual.transform.position.y, actual.transform.position.z);
                cambiar = true;
            }
            else
            {
                actual = baquir;
                baquir.SetActive(false);
               coyote.SetActive(true);
               coyote.transform.position = new Vector3(actual.transform.position.x, actual.transform.position.y, actual.transform.position.z);
                cambiar = false;
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
