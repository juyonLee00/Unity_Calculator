using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWindow : MonoBehaviour
{
    [SerializeField]
    GameObject activeData;

    [SerializeField]
    GameObject inactiveCreditBtn;

    [SerializeField]
    GameObject inactiveWithdrawBtn;

    public void OnClickShowWindow()
    {
        activeData.SetActive(true);
        inactiveCreditBtn.SetActive(false);
        inactiveWithdrawBtn.SetActive(false);
    }
}
