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

    public void PlayGuestAccess()
    {
    SceneManager.LoadScene("Landing",LoadSceneMode.Single);
    }

    public void ScanerAccess()
    {
    SceneManager.LoadScene("Scan",LoadSceneMode.Single);
    }

    public void ReturnToLanding()
    {
    SceneManager.LoadScene("Landing",LoadSceneMode.Single);
    }

    public void LogInAccess()
    {
    SceneManager.LoadScene("LogIn",LoadSceneMode.Single);
    }

}
