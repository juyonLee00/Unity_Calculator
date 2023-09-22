using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class WithdrawBtn : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    TMP_InputField inputField;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject withdrawObject;

    public void ClickBtnName()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        int inputMoney;

        if (String.IsNullOrEmpty(inputField.text))
        {
            inputMoney = int.Parse(clickObject.GetComponentInChildren<TextMeshProUGUI>().text);
        }

        else
        {
            inputMoney = int.Parse(inputField.text);
        }

        Withdraw(inputMoney);
    }

    public void Withdraw(int inputMoney)
    {
        PlayerDataSet playerData = player.GetComponent<PlayerDataSet>();

        int curBalance = playerData.userBalance;

        if (curBalance <= inputMoney)
        {
            panel.SetActive(true);
        }

        else
        {
            playerData.userCash += inputMoney;
            playerData.userBalance -= inputMoney;
        }
    }
}
