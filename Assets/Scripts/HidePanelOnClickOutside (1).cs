using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HidePanelOnClickOutside : MonoBehaviour
{
    void Update()
{
    if (Input.touchCount > 0)
    {
        if (!IsPointerOverUIObject())
            this.gameObject.SetActive(false);
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

    for (int i = 0; i < results.Count; i++)
    {
       if (results[i].gameObject.name == this.gameObject.name)
           return true;
    }
        return false;
    }
}
