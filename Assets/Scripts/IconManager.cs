using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [Header("ICONO 4 POSTES\n")]
    public string nameModel4Postes;
    [SerializeField] Image icon4Postes;
    [SerializeField] Sprite modeloVisto_4P;


    [Header("ICONO SAN PEDRO\n")]
    public string nameModelSanPedro;
    [SerializeField] Image iconSanPedro;
    [SerializeField] Sprite modeloVisto_SP;

    [Header("ICONO CATEDRAL\n")]
    public string nameModelCatedral;
    [SerializeField] Image iconCatedral;
    [SerializeField] Sprite modeloVisto_C;


    private void OnEnable()
    {
        //if(PlayerPrefs.GetInt("Muralla", 0) != 0)
        //    iconMuralla.color = Color.green;

        //Debug.Log(PlayerPrefs.GetInt(nameModel4Postes.ToLower(), 0));

        if (PlayerPrefs.GetInt(nameModel4Postes.ToLower(), 0) != 0)
        {
            icon4Postes.color = Color.white;
            icon4Postes.sprite = modeloVisto_4P;
        }

        if (PlayerPrefs.GetInt(nameModelSanPedro.ToLower(), 0) != 0)
        {
            iconSanPedro.color = Color.white;
            iconSanPedro.sprite = modeloVisto_SP;
        }

        if (PlayerPrefs.GetInt(nameModelCatedral.ToLower(), 0) != 0)
        {
            iconCatedral.color = Color.white;
            iconCatedral.sprite = modeloVisto_C;
        }
    }
}
