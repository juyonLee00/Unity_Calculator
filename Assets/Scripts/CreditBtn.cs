using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class CreditBtn : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    TMP_InputField inputField;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject creditObject;

    public void ClickBtnName()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        int inputMoney;

        if(String.IsNullOrEmpty(inputField.text))
        {
            inputMoney = int.Parse(clickObject.GetComponentInChildren<TextMeshProUGUI>().text);
        }

        else
        {
            inputMoney = int.Parse(inputField.text);
        }
       
        Credit(inputMoney);
    }

    public void Credit(int inputMoney)
    {
        PlayerDataSet playerData = player.GetComponent<PlayerDataSet>();

        int curCash = playerData.userCash;

        if(curCash <= inputMoney)
        {
            panel.SetActive(true);
        }

        else
        {
            playerData.userCash -= inputMoney;
            playerData.userBalance += inputMoney;
        }
    }

}
