using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HidePanelOnClickOutside : MonoBehaviour
{
    [SerializeField] GameObject panel;

    void Update()
{
    if (Input.GetMouseButtonDown(0))
    {
        Debug.Log(Input.GetMouseButtonDown(0));

        if (!IsPointerOverUIObject())
            panel.SetActive(false);
    }
        
}

    private bool IsPointerOverUIObject()
{
    PointerEventData eventData = new PointerEventData(EventSystem.current)
    {
        position = Input.mousePosition
    };

    List<RaycastResult> results = new List<RaycastResult>();
    EventSystem.current.RaycastAll(eventData, results);

    Debug.Log(results.Count);
    Debug.Log(results);

    for (int i = 0; i < results.Count; i++)
    {
        Debug.Log(results[i].gameObject);
    }


    return results.Count > 0; // Devuelve true si tocó UI
}
}
