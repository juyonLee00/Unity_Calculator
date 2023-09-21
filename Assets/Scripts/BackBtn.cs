using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
    [SerializeField]
    GameObject activeCreditBtn;

    [SerializeField]
    GameObject activeWithdrawBtn;

    [SerializeField]
    GameObject inactiveWindow;

    public void OnclickBackMain()
    {
        inactiveWindow.SetActive(false);
        activeCreditBtn.SetActive(true);
        activeWithdrawBtn.SetActive(true);
    }
}
