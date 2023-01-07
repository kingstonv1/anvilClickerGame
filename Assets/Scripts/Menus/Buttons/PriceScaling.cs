using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//this script is a class that processes the price scaling for the shops

public class PriceScaling : MonoBehaviour
{
    public TextMeshProUGUI priceTag;
    public Bank bank;
    public double price;
    public double scaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        priceTag.text = (price.ToString() + " Gold");
    }

    public void Buy()
    {
        if (bank.gold >= price)
        {
            bank.gold -= price;
            price *= scaleFactor;
        }
    }
}
