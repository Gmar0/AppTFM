using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAllData : MonoBehaviour
{
    
    void Awake(){
        PlayerPrefs.DeleteAll();
    PlayerPrefs.Save();

}

}
