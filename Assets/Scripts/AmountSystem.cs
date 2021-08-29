using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmountSystem : MonoBehaviour
{
    public GameObject amountText;
    public int theAmount;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        theAmount += 1;
        amountText.GetComponent<Text>().text = "AMOUNT: " + theAmount;

    }
}
