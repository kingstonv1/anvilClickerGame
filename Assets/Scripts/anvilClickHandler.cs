using UnityEngine;
using TMPro;

public class anvilClickHandler : MonoBehaviour {

    // These variables are all defined through the GUI in Unity.
    public SpriteRenderer spriteRenderer;
    public Sprite idleAnim;  
    public Sprite hitAnim;
    public TextMeshProUGUI pointsLabel;
    public AudioSource sound;

    // setHit and setIdle both just change the sprite of the anvil object.
    private void setHit() {
        spriteRenderer.sprite = hitAnim;
    }
    private void setIdle() {
        spriteRenderer.sprite = idleAnim;
    }

    private void incrementPoints() {
        int currentPoints = int.Parse(pointsLabel.text);
        pointsLabel.text = (currentPoints + 1).ToString();
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
