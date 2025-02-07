using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(SceneManager.GetActiveScene().buildIndex == 0) //Main menu
            Application.Quit();
            else
                SceneManager.LoadScene(0);
        }
    }*/

[SerializeField] GameObject exitPanel;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (SceneManager.GetActiveScene ().buildIndex != 0) {
				SceneManager.LoadScene (0);
			} else {
				if (exitPanel) {
					exitPanel.SetActive (true);
				}
			}
		}
	}

	public void onUserClickYesNo (int choice)
	{//choice==0 no     choice==1 yes
		if (choice == 1) {
			Application.Quit ();
		}
		exitPanel.SetActive (false);//else
	}

	public void onUserClickStart ()
	{
		SceneManager.LoadScene (1);//load game scene
	}

}
