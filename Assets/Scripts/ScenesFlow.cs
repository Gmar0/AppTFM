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
    SceneManager.LoadScene("Map2",LoadSceneMode.Single);
    }

    public void Show_4PModel()
    {
    SceneManager.LoadScene("4P_Model",LoadSceneMode.Single);
    }

    public void Show_AModel()
    {
    SceneManager.LoadScene("A_Model",LoadSceneMode.Single);
    }

    public void Show_SPModel()
    {
    SceneManager.LoadScene("SP_Model",LoadSceneMode.Single);
    }

    public void Show_VModel()
    {
    SceneManager.LoadScene("V_Model",LoadSceneMode.Single);
    }


    public void enlaceVerrTiemblo()
    {
        Application.OpenURL("https://museodeavila.com/pieza/verraco/");
    }

    public void enlaceVerracos()
    {
        Application.OpenURL("https://museodeavila.com/audiovisuales/video-verracos-y-cistas-de-martiherrero/");
    }

    public void enlaceSanPedro()
    {
        Application.OpenURL("https://www.avilaturismo.com/que-ver/san-pedro");
    }

    public void enlace4Postes()
    {
        Application.OpenURL("https://www.avilaturismo.com/que-ver/los-cuatro-postes");
    }

    public void enlaceAdolfoS()
    {
        Application.OpenURL("https://www.avilaturismo.com/personajes-historicos/adolfo-suarez");
    }
}
