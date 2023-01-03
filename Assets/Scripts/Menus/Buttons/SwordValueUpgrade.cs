using UnityEngine;

public class SwordValueUpgrade : MonoBehaviour
{
    public Sprite clicked;
    public Sprite idle;
    public SpriteRenderer spriteRenderer;
    public Bank bank;
    
    private int swordValue;

    // The amount that the sword value will be increased by when the upgrade is purchased.
    private int upgradeValue = 10;
    private int upgradeCost = 100;

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
        
        if (bank.gold >= upgradeCost) 
        {
            bank.gold -= upgradeCost;
            bank.swordValue += upgradeValue;
        }

        Invoke("setIdle", 0.15f);
    }
}
