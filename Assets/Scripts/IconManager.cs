using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [Header("PIN ICON 4 POSTES\n")]
    public string nameModel4Postes;
    [SerializeField] Image icon4Postes;
    [SerializeField] Sprite modeloVisto_4P;


    [Header("PIN ICON SAN PEDRO\n")]
    public string nameModelSanPedro;
    [SerializeField] Image iconSanPedro;
    [SerializeField] Sprite modeloVisto_SP;

    [Header("PIN ICON ADOLFO SUAREZ\n")]
    public string nameModelAdolfo;
    [SerializeField] Image iconAdolfo;
    [SerializeField] Sprite modeloVisto_A;

    [Header("IMAGEN 4 POSTES\n")]
    //public string nameModel4P_Image;
    [SerializeField] Image image4Postes;
    [SerializeField] Sprite imageVista_4P;


    [Header("IMAGEN SAN PEDRO\n")]
    //public string nameModelSP_Image;
    [SerializeField] Image imageSanPedro;
    [SerializeField] Sprite imageVista_SP;

    [Header("IMAGEN ADOLFO SUAREZ\n")]
    //public string nameModelA_Image;
    [SerializeField] Image imageAdolfo;
    [SerializeField] Sprite imageVista_A;

    [Header("PIN ICON VERRACO 1\n")]
    public string nameModelVerraco1;
    [SerializeField] Image iconVerraco1;
    [SerializeField] Sprite modeloVisto_V1;

    [Header("PIN ICON VERRACO 2\n")]
    public string nameModelVerraco2;
    [SerializeField] Image iconVerraco2;
    [SerializeField] Sprite modeloVisto_V2;

    [Header("PIN ICON VERRACO 3\n")]
    public string nameModelVerraco3;
    [SerializeField] Image iconVerraco3;
    [SerializeField] Sprite modeloVisto_V3;

    [Header("PIN ICON VERRACO 4\n")]
    public string nameModelVerraco4;
    [SerializeField] Image iconVerraco4;
    [SerializeField] Sprite modeloVisto_V4;

    [Header("PIN ICON VERRACO 5\n")]
    public string nameModelVerraco5;
    [SerializeField] Image iconVerraco5;
    [SerializeField] Sprite modeloVisto_V5;

    [Header("PIN ICON VERRACO 6\n")]
    public string nameModelVerraco6;
    [SerializeField] Image iconVerraco6;
    [SerializeField] Sprite modeloVisto_V6;

    [Header("PIN ICON VERRACO 7\n")]
    public string nameModelVerraco7;
    [SerializeField] Image iconVerraco7;
    [SerializeField] Sprite modeloVisto_V7;

    private void OnEnable()
    {
        //if(PlayerPrefs.GetInt("Muralla", 0) != 0)
        //    iconMuralla.color = Color.green;

        //Debug.Log(PlayerPrefs.GetInt(nameModel4Postes.ToLower(), 0));

        if (PlayerPrefs.GetInt(nameModel4Postes.ToLower(), 0) != 0)
        {
            //icon4Postes.color = Color.white;
            icon4Postes.sprite = modeloVisto_4P;
            image4Postes.sprite = imageVista_4P;
        }

        if (PlayerPrefs.GetInt(nameModelSanPedro.ToLower(), 0) != 0)
        {
            iconSanPedro.color = Color.white;
            iconSanPedro.sprite = modeloVisto_SP;
            imageSanPedro.sprite = imageVista_SP;
        }

        if (PlayerPrefs.GetInt(nameModelAdolfo.ToLower(), 0) != 0)
        {
            iconAdolfo.color = Color.white;
            iconAdolfo.sprite = modeloVisto_A;
            imageAdolfo.sprite = imageVista_A;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco1.ToLower(), 0) != 0)
        {
            iconVerraco1.color = Color.white;
            iconVerraco1.sprite = modeloVisto_V1;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco2.ToLower(), 0) != 0)
        {
            iconVerraco2.color = Color.white;
            iconVerraco2.sprite = modeloVisto_V2;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco3.ToLower(), 0) != 0)
        {
            iconVerraco3.color = Color.white;
            iconVerraco3.sprite = modeloVisto_V3;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco4.ToLower(), 0) != 0)
        {
            iconVerraco4.color = Color.white;
            iconVerraco4.sprite = modeloVisto_V4;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco5.ToLower(), 0) != 0)
        {
            iconVerraco5.color = Color.white;
            iconVerraco5.sprite = modeloVisto_V5;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco6.ToLower(), 0) != 0)
        {
            iconVerraco6.color = Color.white;
            iconVerraco6.sprite = modeloVisto_V6;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco7.ToLower(), 0) != 0)
        {
            iconVerraco7.color = Color.white;
            iconVerraco7.sprite = modeloVisto_V7;
        }
    }
}
