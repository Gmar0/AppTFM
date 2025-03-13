using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCam : MonoBehaviour
{

    [SerializeField]
    private Camera cam; //obiekt kamery

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize; //zakres powiększenia

    [SerializeField]
    private RectTransform mapRenderer;
    private float mapMinX, mapMaxX, mapMinY, mapMaxY;

    private Vector3 dragOrigin;
    [SerializeField]
    private float zoomSpeed = 5f;

    [SerializeField] private float zoomMobile = 1f;

    private void Awake()
    {

        Debug.Log($"Map Position: {mapRenderer.position}, Map Size: {mapRenderer.rect.width} x {mapRenderer.rect.height}");
        Debug.Log($"Camera Position: {cam.transform.position}, Camera Size: {cam.orthographicSize}");

        float mapWidth = mapRenderer.rect.width * mapRenderer.lossyScale.x;
        float mapHeight = mapRenderer.rect.height * mapRenderer.lossyScale.y;


        Vector3 mapPosition = mapRenderer.position;

        mapMinX = mapPosition.x - (mapWidth / 2f);
        mapMaxX = mapPosition.x + (mapWidth / 2f);
        mapMinY = mapPosition.y - (mapHeight / 2f);
        mapMaxY = mapPosition.y + (mapHeight / 2f);

        Debug.Log($"New Map Bounds: MinX={mapMinX}, MaxX={mapMaxX}, MinY={mapMinY}, MaxY={mapMaxY}");
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchSupported && Input.touchCount > 0)
        {
            HandleTouchInput();
        }
        else
        {
            PanCamera();
            HandleMouseZoom();
        }
    }
    private void HandleMouseZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            Zoom(scroll * -zoomSpeed);
        }
    }
    private void HandleTouchInput()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
                dragOrigin = cam.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, cam.nearClipPlane));

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 newPosition = cam.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, cam.nearClipPlane));
                Vector3 difference = dragOrigin - newPosition;

                if (difference.magnitude > 0.01f)
                {
                    cam.transform.position = ClampCamera(cam.transform.position + difference * moveSpeed);
                    dragOrigin = cam.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, cam.nearClipPlane));
                }
            }
        }


        /// esto para el pinch porque hay dos toques
        ///        
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = prevMagnitude - currentMagnitude;

            Zoom(difference * zoomMobile);
        }
    }


        //przesuwanie pozycji kamery (lewo, prawo, góra, dół)
        private void PanCamera()
    {

        if (Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
            Vector3 difference = (dragOrigin - newPosition);

            if (difference.magnitude > 0.01f) // aqui filtro cosas raras

            {
                cam.transform.position = ClampCamera(cam.transform.position + difference * moveSpeed);

                dragOrigin = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
            }

        }

        /*
        if (Input.GetMouseButtonDown(0)) dragOrigin = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z * -1));
        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z * -1));
            Debug.Log("origin " + dragOrigin + " newPosition " + cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.z * -1)) + " =difference " + difference);
            cam.transform.position += new Vector3(difference.x, difference.y, 0f);
        }
        */
    }
        public void Zoom(float increment)
        {
        Debug.Log(" zooming + " + increment);
            float newSize = cam.orthographicSize + increment;
        Debug.Log("new size " + newSize);
            cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
            cam.transform.position = ClampCamera(cam.transform.position);
        }

        public void ZoomIn()
    {
        float newSize = cam.orthographicSize - zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position);   //ograniczenie obszaru
    }

    public void ZoomOut()
    {
        float newSize = cam.orthographicSize + zoomStep;
        cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        cam.transform.position = ClampCamera(cam.transform.position); //ograniczenie obszaru
        
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;
        Debug.Log(camWidth);

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }

}