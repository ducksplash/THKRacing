using UnityEngine;
using TMPro;

public class SwitchCams : MonoBehaviour
{
    public Camera CamOne;
    public Camera CamTwo;
    public Camera CamThree;
    public int CamNo;
    public TextMeshProUGUI CamOneLabel;
    public TextMeshProUGUI CamTwoLabel;
    public TextMeshProUGUI CamThreeLabel;

    public Camera WingCamLeft;
    public Camera WingCamRight;
    public Camera RearViewCam;
    public Camera TopViewCam;

    private void Start()
    {
        CamNo = 0;
    }


    public void ToggleCams()
    {
        if (CamNo == 0)
        {
            Debug.Log(CamNo);
            CamOneLabel.color = new Color32(190, 190, 190, 255);
            CamTwoLabel.color = new Color32(0, 170, 0, 255);
            CamThreeLabel.color = new Color32(190, 190, 190, 255);
            CamOne.enabled = false;
            CamTwo.enabled = true;
            CamThree.enabled = false;


            WingCamLeft.enabled = false;
            WingCamRight.enabled = false;
            RearViewCam.enabled = false;
            TopViewCam.enabled = false;
            CamNo = 1;
        }
        else if (CamNo == 1)
        {
            Debug.Log(CamNo);
            CamOneLabel.color = new Color32(190, 190, 190, 255);
            CamTwoLabel.color = new Color32(190, 190, 190, 255);
            CamThreeLabel.color = new Color32(0, 170, 0, 255);
            CamOne.enabled = false;
            CamTwo.enabled = false;
            CamThree.enabled = true;

            WingCamLeft.enabled = true;
            WingCamRight.enabled = true;
            RearViewCam.enabled = true;
            TopViewCam.enabled = true;
            CamNo = 2;
        }
        else if (CamNo == 2)
        {
            Debug.Log(CamNo);
            CamOneLabel.color = new Color32(0, 170, 0, 255);
            CamTwoLabel.color = new Color32(190, 190, 190, 255);
            CamThreeLabel.color = new Color32(190, 190, 190, 255);
            CamOne.enabled = true;
            CamTwo.enabled = false;
            CamThree.enabled = false;

            WingCamLeft.enabled = false;
            WingCamRight.enabled = false;
            RearViewCam.enabled = false;
            TopViewCam.enabled = false;
            CamNo = 0;
        }
    }


}
