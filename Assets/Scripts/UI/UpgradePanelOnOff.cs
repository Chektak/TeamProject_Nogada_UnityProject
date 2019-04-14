using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelOnOff : MonoBehaviour {
    public Sprite upStateSprite;
    public Sprite downStateSprite;
    public GameObject upStateNogadaButton;
    public GameObject downStateNogadaButton;
    public GameObject statUpgradePanel;
    public float upState_BtnPosY=0;
    public bool canUp=true;

    private RectTransform rect;
    private Image image;
    public void Awake()
    {
        rect = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }
    public void PanelUpDown()
    {
        if (canUp == true) {
            image.sprite = upStateSprite;
            rect.anchoredPosition3D += new Vector3(0, upState_BtnPosY, 0);
            statUpgradePanel.SetActive(true);
            upStateNogadaButton.SetActive(false);
            downStateNogadaButton.SetActive(true);
            canUp = false;
        }
        else
        {
            image.sprite = downStateSprite;
            rect.anchoredPosition3D -= new Vector3(0, upState_BtnPosY, 0);
            statUpgradePanel.SetActive(false);
            upStateNogadaButton.SetActive(true);
            downStateNogadaButton.SetActive(false);
            canUp = true;
        }
    }
}
