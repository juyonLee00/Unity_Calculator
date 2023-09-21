using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSetActive : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void OnClickPanelOff()
    {
        panel.SetActive(false);
    }

    public void OnClickActivationPanel()
    {
        panel.SetActive(true);
    }
}
