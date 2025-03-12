using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    [Header("PIN ICON 4 POSTES\n")]
    public string nameModel4Postes;
    [SerializeField] Image icon4Postes;
    [SerializeField] Sprite modeloVisto_4P;
    [SerializeField] Image lockedButton_4P;
    [SerializeField] Sprite unlockedButton_4P;



    [Header("PIN ICON SAN PEDRO\n")]
    public string nameModelSanPedro;
    [SerializeField] Image iconSanPedro;
    [SerializeField] Sprite modeloVisto_SP;
    [SerializeField] Image lockedButton_SP;
    [SerializeField] Sprite unlockedButton_SP;

    [Header("PIN ICON ADOLFO SUAREZ\n")]
    public string nameModelAdolfo;
    [SerializeField] Image iconAdolfo;
    [SerializeField] Sprite modeloVisto_A;
    [SerializeField] Image lockedButton_A;
    [SerializeField] Sprite unlockedButton_A;

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
    [SerializeField] Image V1_LockPanel;
    [SerializeField] Sprite V1_UNLockPanel;
    [SerializeField] Image V1_LockImage;
    [SerializeField] Sprite V1_UNLockImage;

    [Header("PIN ICON VERRACO 2\n")]
    public string nameModelVerraco2;
    [SerializeField] Image iconVerraco2;
    [SerializeField] Sprite modeloVisto_V2;
    [SerializeField] Image V2_LockPanel;
    [SerializeField] Sprite V2_UNLockPanel;
    [SerializeField] Image V2_LockImage;
    [SerializeField] Sprite V2_UNLockImage;

    [Header("PIN ICON VERRACO 3\n")]
    public string nameModelVerraco3;
    [SerializeField] Image iconVerraco3;
    [SerializeField] Sprite modeloVisto_V3;
    [SerializeField] Image V3_LockPanel;
    [SerializeField] Sprite V3_UNLockPanel;
    [SerializeField] Image V3_LockImage;
    [SerializeField] Sprite V3_UNLockImage;

    [Header("PIN ICON VERRACO 4\n")]
    public string nameModelVerraco4;
    [SerializeField] Image iconVerraco4;
    [SerializeField] Sprite modeloVisto_V4;
    [SerializeField] Image V4_LockPanel;
    [SerializeField] Sprite V4_UNLockPanel;
    [SerializeField] Image V4_LockImage;
    [SerializeField] Sprite V4_UNLockImage;

    [Header("PIN ICON VERRACO 5\n")]
    public string nameModelVerraco5;
    [SerializeField] Image iconVerraco5;
    [SerializeField] Sprite modeloVisto_V5;
    [SerializeField] Image V5_LockPanel;
    [SerializeField] Sprite V5_UNLockPanel;
    [SerializeField] Image V5_LockImage;
    [SerializeField] Sprite V5_UNLockImage;

    [Header("PIN ICON VERRACO 6\n")]
    public string nameModelVerraco6;
    [SerializeField] Image iconVerraco6;
    [SerializeField] Sprite modeloVisto_V6;
    [SerializeField] Image V6_LockPanel;
    [SerializeField] Sprite V6_UNLockPanel;
    [SerializeField] Image V6_LockImage;
    [SerializeField] Sprite V6_UNLockImage;

    [Header("PIN ICON VERRACO 7\n")]
    public string nameModelVerraco7;
    [SerializeField] Image iconVerraco7;
    [SerializeField] Sprite modeloVisto_V7;
    [SerializeField] Image V7_LockPanel;
    [SerializeField] Sprite V7_UNLockPanel;
    [SerializeField] Image V7_LockImage;
    [SerializeField] Sprite V7_UNLockImage;

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
            lockedButton_4P.sprite = unlockedButton_4P;
        }

        if (PlayerPrefs.GetInt(nameModelSanPedro.ToLower(), 0) != 0)
        {
            iconSanPedro.color = Color.white;
            iconSanPedro.sprite = modeloVisto_SP;
            imageSanPedro.sprite = imageVista_SP;
            lockedButton_SP.sprite = unlockedButton_SP;
            
        }

        if (PlayerPrefs.GetInt(nameModelAdolfo.ToLower(), 0) != 0)
        {
            iconAdolfo.color = Color.white;
            iconAdolfo.sprite = modeloVisto_A;
            imageAdolfo.sprite = imageVista_A;
            lockedButton_A.sprite = unlockedButton_A;

        }

        if (PlayerPrefs.GetInt(nameModelVerraco1.ToLower(), 0) != 0)
        {
            iconVerraco1.color = Color.white;
            iconVerraco1.sprite = modeloVisto_V1;
            V1_LockPanel.sprite = V1_UNLockPanel;
            V1_LockImage.sprite = V1_UNLockImage;
        }

        if (PlayerPrefs.GetInt(nameModelVerraco2.ToLower(), 0) != 0)
        {
            iconVerraco2.color = Color.white;
            iconVerraco2.sprite = modeloVisto_V2;
            V2_LockPanel.sprite = V2_UNLockPanel;
            V2_LockImage.sprite = V2_UNLockImage;

        }

        if (PlayerPrefs.GetInt(nameModelVerraco3.ToLower(), 0) != 0)
        {
            iconVerraco3.color = Color.white;
            iconVerraco3.sprite = modeloVisto_V3;
            V3_LockPanel.sprite = V3_UNLockPanel;
            V3_LockImage.sprite = V3_UNLockImage;

        }

        if (PlayerPrefs.GetInt(nameModelVerraco4.ToLower(), 0) != 0)
        {
            iconVerraco4.color = Color.white;
            iconVerraco4.sprite = modeloVisto_V4;
            V4_LockPanel.sprite = V4_UNLockPanel;
            V4_LockImage.sprite = V4_UNLockImage;
        
        }

        if (PlayerPrefs.GetInt(nameModelVerraco5.ToLower(), 0) != 0)
        {
            iconVerraco5.color = Color.white;
            iconVerraco5.sprite = modeloVisto_V5;
            V5_LockPanel.sprite = V5_UNLockPanel;
            V5_LockImage.sprite = V5_UNLockImage;

        }

        if (PlayerPrefs.GetInt(nameModelVerraco6.ToLower(), 0) != 0)
        {
            iconVerraco6.color = Color.white;
            iconVerraco6.sprite = modeloVisto_V6;
            V6_LockPanel.sprite = V6_UNLockPanel;
            V6_LockImage.sprite = V6_UNLockImage;

        }

        if (PlayerPrefs.GetInt(nameModelVerraco7.ToLower(), 0) != 0)
        {
            iconVerraco7.color = Color.white;
            iconVerraco7.sprite = modeloVisto_V7;
            V7_LockPanel.sprite = V7_UNLockPanel;
            V7_LockImage.sprite = V7_UNLockImage;

        }
    }
}
