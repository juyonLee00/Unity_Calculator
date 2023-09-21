using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class CheckSignupValidation : MonoBehaviour
{
    [SerializeField]
    TMP_InputField idInputField;

    [SerializeField]
    TMP_InputField nameInputField;

    [SerializeField]
    TMP_InputField pwInputField;

    [SerializeField]
    TMP_InputField pwConfirmInputField;

    [SerializeField]
    GameObject checkInfoPanel;

    [SerializeField]
    TextMeshProUGUI errorMessage;

    [SerializeField]
    GameObject signUpPanel;

    bool correctIDValidation = false;
    bool correctNameValidation = false;
    bool correctPWValidation = false;
    bool correctPWConfirmValidation = false;

    int defaultCashData = 50000;
    int defaultBalanceData = 100000;

    public void OnClickCheckSignUp()
    {
        CheckID();
        CheckName();
        CheckPW();
        CheckPWConfirm();

        if(correctIDValidation && correctNameValidation && correctPWValidation && correctPWConfirmValidation)
        {
            SaveUserData();
            signUpPanel.SetActive(false);
        }

        else
        {
            if (!correctIDValidation)
                errorMessage.text = "Check your ID";

            else if (!correctNameValidation)
                errorMessage.text = "Check your Name";
            
            else if (!correctPWValidation)
                errorMessage.text = "Check your PW";

            else
                errorMessage.text = "Check your PW Confirm";
            

            checkInfoPanel.SetActive(true);
        }
    }

    void CheckID()
    {
        if(idInputField.text.Length >= 3)
        {
            if(PlayerPrefs.HasKey(idInputField.text))
            {
                correctIDValidation = true;
            }
        }
    }


    void CheckName()
    {
        if(nameInputField.text.Length >= 2)
        {
            correctNameValidation = true;
        }
    }


    void CheckPW()
    {
        if (pwInputField.text.Length >= 5)
        {
            correctPWValidation = true;
        }

    }


    void CheckPWConfirm()
    {
        if(pwInputField.text == pwConfirmInputField.text)
        {
            correctPWConfirmValidation = true;
        }
    }

    void SaveUserData()
    {
        PlayerPrefs.SetString("ID", idInputField.text);
        PlayerPrefs.SetString("PW", pwInputField.text);
        PlayerPrefs.SetInt("Cash", defaultCashData);
        PlayerPrefs.SetInt("Balance", defaultBalanceData);
    }
}
