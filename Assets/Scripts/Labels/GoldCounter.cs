using UnityEngine;
using TMPro;

public class GoldCounter : MonoBehaviour
{
    public TextMeshProUGUI goldLabel;
    public Bank bank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldLabel.text = (bank.gold.ToString() + " " + "Gold");
    }
}
