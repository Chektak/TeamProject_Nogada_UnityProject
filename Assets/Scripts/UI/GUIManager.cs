using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {
    [Header("PANELSTATE의 순서에 따라 패널들을 넣는다.")]
    public GameObject[] panels;
    public Button[] buttons;
    public enum PANELSTATE { TRAINING=0, SHOP, STORY, STORYBOOK, OPTION };
    public PANELSTATE nowPanelState = PANELSTATE.TRAINING;
    public void SetNowPanelState(int changeState)
    {
        ColorBlock col = buttons[(int)nowPanelState].colors;
        col.colorMultiplier = 1.5f;
        buttons[(int)nowPanelState].colors = col;
        panels[(int)nowPanelState].SetActive(false);

        nowPanelState = (PANELSTATE)changeState;

        col = buttons[(int)nowPanelState].colors;
        col.colorMultiplier = 1;
        buttons[(int)nowPanelState].colors = col;
    }
}
