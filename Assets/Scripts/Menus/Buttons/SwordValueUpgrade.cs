using UnityEngine;

public class SwordValueUpgrade : MonoBehaviour
{
    public Sprite clicked;
    public Sprite idle;
    public SpriteRenderer spriteRenderer;
    public Bank bank;
    public PriceScaling price;
    
    private double swordValue;

    // The amount that the sword value will be increased by when the upgrade is purchased.
    private int upgradeValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setClicked() 
    {
        spriteRenderer.sprite = clicked;
    }

    void setIdle() 
    {
        spriteRenderer.sprite = idle;
    }

    void OnMouseDown() 
    {
        setClicked();

        if (bank.gold >= price.price) 
        {
            bank.swordValue += upgradeValue;
        }
        price.Buy();

        Invoke("setIdle", 0.15f);
    }
}
