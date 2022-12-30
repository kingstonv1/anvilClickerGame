using UnityEngine;
using TMPro;

public class anvilClickHandler : MonoBehaviour {

    // These variables are all defined through the GUI in Unity.
    public SpriteRenderer spriteRenderer;
    public Sprite idleAnim;  
    public Sprite hitAnim;
    public TextMeshProUGUI pointsLabel1;
    public TextMeshProUGUI pointsLabel2;
    public AudioSource sound;

    //moved currentPoints to a public variable for use in other places --Caleb
    public int currentPoints = 0;

    // setHit and setIdle both just change the sprite of the anvil object.
    private void setHit() {
        spriteRenderer.sprite = hitAnim;
    }
    private void setIdle() {
        spriteRenderer.sprite = idleAnim;
    }

    private void incrementPoints() {
        currentPoints = (currentPoints + 1);
        pointsLabel1.text = (currentPoints).ToString();
        pointsLabel2.text = ((currentPoints).ToString() + "/10");

        //resets the counter when a sword is forged
        if(int.Parse(pointsLabel1.text) >= 10)
        {
            currentPoints = currentPoints - 10;
        }
    }

    private void playHitSound() {
        sound.Play();
    }



    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update(){
        
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
