using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldPerSecondText : MonoBehaviour
{
    public TextMeshProUGUI GPSText;
    public Bank bank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GPSText.text = (((bank.apprentices * bank.apprenticeLevel) +
            (bank.smithies * bank.smithiesLevel) +
            (bank.mines * bank.minesLevel)).ToString() + " Gold/Sec");
    }
}
