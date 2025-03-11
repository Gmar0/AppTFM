using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesFlow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScanerAccess()
    {
    SceneManager.LoadScene("Scan",LoadSceneMode.Single);
    }

    public void ReturnToLanding()
    {
    SceneManager.LoadScene("Landing",LoadSceneMode.Single);
    }

    public void GoMAp()
    {
    SceneManager.LoadScene("Map",LoadSceneMode.Single);
    }


    public void enlaceInternet()
    {
        Application.OpenURL("https://www.avilaturismo.com/que-ver");
    }
}
