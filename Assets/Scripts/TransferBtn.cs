using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TransferBtn : MonoBehaviour
{
    [SerializeField]
    TMP_InputField destInputField;

    [SerializeField]
    TMP_InputField cashInputField;

    [SerializeField]
    GameObject checkInputInfoPanel;

    [SerializeField]
    GameObject checkBalanceInfoPanel;

    [SerializeField]
    GameObject checkUserIDPanel;

    [SerializeField]
    GameObject player;

    int transferCash = 0;
    string destData = "";

    bool checkBalanceInfo = false;
    bool checkUserID = false;

    public void OnClickTransferBtn()
    {
        InitialCheckData();

        try
        {
            transferCash = int.Parse(cashInputField.text);
            destData = destInputField.text; 
        }

        catch
        {
            CheckInputField();
        }
        
        PlayerDataSet playerData = player.GetComponent<PlayerDataSet>();

        CheckUserBalance(transferCash, playerData);
        CheckDestination(destData);

        if(checkBalanceInfo && checkUserID)
        {
            TransferCash(ref playerData, transferCash);
        }
    }

    void InitialCheckData()
    {
        checkBalanceInfo = false;
        checkUserID = false;
    }

    void TransferCash(ref PlayerDataSet playerData, int transferCash)
    {
        playerData.userBalance -= transferCash;

        int destBalance = PlayerPrefs.GetInt("Balance");
        destBalance += transferCash;
        PlayerPrefs.SetInt("Balance", destBalance);

    }

    void CheckDestination(string destData)
    {
        if (!destData.Equals(PlayerPrefs.GetString("ID")))
        {
            checkUserIDPanel.SetActive(true);
        }
        else
        {
            checkUserID = true;
        }
    }


    void CheckUserBalance(int transferCash, PlayerDataSet playerData)
    {
        if (transferCash > playerData.userBalance)
        {
            checkBalanceInfoPanel.SetActive(true);
        }
        else
        {
            checkBalanceInfo = true;
        }
    }

    void CheckInputField()
    {
        if (String.IsNullOrEmpty(destInputField.text) || String.IsNullOrEmpty(cashInputField.text))
        {
            checkInputInfoPanel.SetActive(true);
        }
    }
}
