using UnityEngine;

public class ApprenticeUpgrade : MonoBehaviour
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

        
        if (bank.gold >= price.price)
        {
            bank.apprentices++;
        }
        price.Buy();
    

        Invoke("setIdle", 0.15f);
    }
}
