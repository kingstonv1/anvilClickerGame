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
        // The parameter in ToString formats the number with commas.
        goldLabel.text = (bank.gold.ToString("#,##0"));
    }
}
