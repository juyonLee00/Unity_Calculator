using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoginBtn : MonoBehaviour
{
    [SerializeField]
    TMP_InputField idInputField;

    [SerializeField]
    TMP_InputField pwInputField;

    [SerializeField]
    GameObject wrongLoginPanel;

    bool isLogin = false;

    public void OnClickLogin()
    {
        if(PlayerPrefs.HasKey("ID"))
        {
            string inputId = idInputField.text;
            string inputPw = pwInputField.text;

            if(inputId.Equals(PlayerPrefs.GetString("ID")) && inputPw.Equals(PlayerPrefs.GetString("PW")))
            {
                isLogin = true;
                SceneManager.LoadScene("MainScene");
            }
        }

    }

}
