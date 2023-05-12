using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    private int TargetFrameRate = 30;
    GameObject player;
    [SerializeField] private GameObject coyote;
    [SerializeField] private GameObject baquir;

    [SerializeField] private Transform PlayerSpawnPoint;
    [SerializeField] CinemachineVirtualCamera VCam;
  

    [SerializeField] private bool characterExists;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = TargetFrameRate;
        if(coyote.active==true)
        {
            
            VCam.Follow = coyote.transform;
            VCam.LookAt = coyote.transform;
            
        }
       if(baquir.active == true)
        {
            VCam.Follow = baquir.transform;
            VCam.LookAt = baquir.transform;
        }
        
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        else if (Input.GetKeyDown(KeyCode.T)) SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        if (coyote.active == true)
        {

            VCam.Follow = coyote.transform;
            VCam.LookAt = coyote.transform;

        }
        if (baquir.active == true)
        {
            VCam.Follow = baquir.transform;
            VCam.LookAt = baquir.transform;
        }
    }
}
