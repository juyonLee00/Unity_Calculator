using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class CreditBtn : MonoBehaviour
{
    public void ClickBtnName()
    {
        Debug.Log("click btn");

        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        Debug.Log(clickObject.name + ", " + clickObject.GetComponentInChildren<TextMeshProUGUI>().text);
    }

    //처음에 가져올 버튼 오브젝트 가져오기

    //해당 버튼 클릭시 플레이어의 balance, cash 값에 따라 팝업 띄울건지 값 옮길건지 결정.
}
