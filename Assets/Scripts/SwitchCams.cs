using UnityEngine;
using TMPro;

public class SwitchCams : MonoBehaviour
{
    public Camera CamOne;
    public Camera CamTwo;
    public int CamNo;
    public TextMeshProUGUI CamOneLabel;
    public TextMeshProUGUI CamTwoLabel;

    private void Start()
    {
        CamNo = 0;
    }


    public void ToggleCams()
    {
        if (CamNo == 0)
        {
            Debug.Log(CamNo);
            CamOneLabel.color = new Color32(100, 100, 100, 255);
            CamTwoLabel.color = new Color32(255, 255, 255, 255);
            CamOne.enabled = false;
            CamTwo.enabled = true;
            CamNo = 1;
        }
        else if (CamNo == 1)
        {
            Debug.Log(CamNo);
            CamTwoLabel.color = new Color32(100, 100, 100, 255);
            CamOneLabel.color = new Color32(255, 255, 255, 255);
            CamOne.enabled = true;
            CamTwo.enabled = false;
            CamNo = 0;
        }
    }


}
