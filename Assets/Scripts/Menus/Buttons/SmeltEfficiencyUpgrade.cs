using UnityEngine;

public class SmeltEfficiencyUpgrade : MonoBehaviour
{
    public Sprite clicked;
    public Sprite idle;
    public SpriteRenderer spriteRenderer;
    public Bank bank;
    public PriceScaling price;

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

        if (bank.swordPoints > 3)
        {
            if (bank.gold >= price.price)
            {
                bank.swordPoints--;
            }
            price.Buy();
        }

        Invoke("setIdle", 0.15f);
    }
}
