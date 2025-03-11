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

    public void SaveAdolfoScanned(string nameModelAdolfo)
    {
        PlayerPrefs.SetInt(nameModelAdolfo.ToLower(), 1);
    }

    public void SaveV1Scanned(string nameModelVerraco1)
    {
        PlayerPrefs.SetInt(nameModelVerraco1.ToLower(), 1);
    }

    public void SaveV2Scanned(string nameModelVerraco2)
    {
        PlayerPrefs.SetInt(nameModelVerraco2.ToLower(), 1);
    }
    
    public void SaveV3Scanned(string nameModelVerraco3)
    {
        PlayerPrefs.SetInt(nameModelVerraco3.ToLower(), 1);
    }

    public void SaveV4Scanned(string nameModelVerraco4)
    {
        PlayerPrefs.SetInt(nameModelVerraco4.ToLower(), 1);
    }

    public void SaveV5Scanned(string nameModelVerraco5)
    {
        PlayerPrefs.SetInt(nameModelVerraco5.ToLower(), 1);
    }

    public void SaveV6Scanned(string nameModelVerraco6)
    {
        PlayerPrefs.SetInt(nameModelVerraco6.ToLower(), 1);
    }

    public void SaveV7Scanned(string nameModelVerraco7)
    {
        PlayerPrefs.SetInt(nameModelVerraco7.ToLower(), 1);
    }
}
