using UnityEngine;
using TMPro;

public class anvilClickHandler : MonoBehaviour {

    // These variables are all defined through the GUI in Unity.
    public SpriteRenderer spriteRenderer;
    public Sprite idleAnim;  
    public Sprite hitAnim;
    public TextMeshProUGUI pointsLabel;
    public TextMeshProUGUI swordProgressLabel;
    public TextMeshProUGUI goldLabel;
    public AudioSource sound;
    public AudioSource sound2;
    public Bank bank;

    //moved currentPoints to a public variable for use in other places --Caleb
    public int currentPoints;
    public int swordValue;
    public int totalClicks;

    //setHit and setIdle both just change the sprite of the anvil object.
    private void setHit() {
        spriteRenderer.sprite = hitAnim;
    }
    private void setIdle() {
        spriteRenderer.sprite = idleAnim;
    }

    private void incrementPoints() {
        //resets the counter when a sword is forged
        currentPoints = (currentPoints + 1);

        if (currentPoints == 10)
        {
            currentPoints = currentPoints - 10;

            //Add the value of the sword you just forged to your total gold
            bank.gold += bank.swordValue;

            //Update the counter
            goldLabel.text = ((bank.gold).ToString() + " Gold");
            playCoinSound();
        }

        pointsLabel.text = (currentPoints).ToString();
        swordProgressLabel.text = ((currentPoints).ToString() + "/10");
    }

    private void playHitSound() {
        sound.Play();
    }

    private void playCoinSound()
    {
        sound2.Play();
    }

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        incrementPoints();
        setHit();
        playHitSound();

        // An invoke statement is used here to delay the function by .15 seconds.
        // This gives a delay before the click "animation" is finished.
        Invoke("setIdle", 0.15f);
    }
}
