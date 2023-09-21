using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class InputFieldCredit : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputMoney;

    public void GetInputMoney()
    {
        
        Debug.Log(inputMoney.text);
    }
}
