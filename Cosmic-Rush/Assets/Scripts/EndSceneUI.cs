using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndSceneUI : MonoBehaviour
{
    public ManagerScene mngscn;
    public TextMeshProUGUI timeText;

    void Start()
    {
        mngscn = FindObjectOfType<ManagerScene>();
        string overText = mngscn.StartOver();
        float elapsedTime = mngscn.GetElapsedTime();
        timeText.text = overText + "\n" + "Toplam S�re: " + elapsedTime.ToString("F2") + " saniye";
    }
}