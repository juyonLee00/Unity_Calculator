using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.UI;

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

    string regexStr;

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
        regexStr = Regex.Replace(idInputField.text, @"[^a-zA-Z0-9]", "");

        if(regexStr == idInputField.text)
        {
            correctIDValidation = false;
            return;
        }

        if(idInputField.text.Length >= 3)
        {
            //data파일 존재하는지 확인
            if(true)
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
        regexStr = Regex.Replace(pwInputField.text, @"[^a-zA-Z0-9]", "");

        if (regexStr == pwInputField.text)
        {
            correctPWValidation = false;
            return;
        }

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

    }
}
