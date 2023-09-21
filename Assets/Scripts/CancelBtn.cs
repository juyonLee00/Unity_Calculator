using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelBtn : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void OnClickClosePanel()
    {
        panel.SetActive(false);
    }
}
