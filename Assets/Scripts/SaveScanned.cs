using UnityEngine;

public class SaveScaned : MonoBehaviour
{

    public void Save4PostScanned(string nameModel4Postes)
    {
        PlayerPrefs.SetInt(nameModel4Postes.ToLower(), 1);
    }

    public void SaveSanPeScanned(string nameModelSanPedro)
    {
        PlayerPrefs.SetInt(nameModelSanPedro.ToLower(), 1);
    }

    public void SaveCathScanned(string nameModelCatedral)
    {
        PlayerPrefs.SetInt(nameModelCatedral.ToLower(), 1);
    }
}
