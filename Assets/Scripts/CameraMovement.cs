using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /*[SerializeField]
    private Camera cam;
    private Vector3 dragOrigin;
    */

    Vector3 touchStart;


    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
        }

    }





    /*private void Update()
    {

            PanCamara();

    }
    

    /*private void PanCamara()
    {
        // Save position of the mouse in the world space when drag stars (first time clicked)

        if(Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);


        //calculate distance between drag origin and new position if it is still held down

        if(Input.GetMouseButton(0))
        {

        Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);

        print("origin " + dragOrigin + " newPosition " + cam.ScreenToWorldPoint(Input.mousePosition) + " =difference" + difference);


        //move the camera by that distance    
        cam.transform.position += difference;

        }
        
        

    }*/



}
