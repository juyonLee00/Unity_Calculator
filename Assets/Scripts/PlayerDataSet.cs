using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataSet : MonoBehaviour
{
    [SerializeField]
    public string userName = "chad";

    [SerializeField]
    public int userCash = 100000;

    [SerializeField]
    public int userBalance = 500000;

    [SerializeField]
    public TextMeshProUGUI cashObject;

    [SerializeField]
    public TextMeshProUGUI nameObject;

    [SerializeField]
    public TextMeshProUGUI balanceObject;

    void Start()
    {
        cashObject.text = userCash.ToString();
        nameObject.text = userName;
        balanceObject.text = userBalance.ToString();
    }

    
}
