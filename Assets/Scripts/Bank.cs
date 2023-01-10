using UnityEngine;

//This script is a class that holds all of the global variables needed for the game


public class Bank : MonoBehaviour
{
    public double gold = 0;
    public double swordValue = 50;
    public double totalClicks = 0;
    public int swordPoints = 10;

    public double apprentices = 0;
    public double apprenticeLevel = 1;
    public double smithies = 0;
    public double smithiesLevel = 10;
    public double mines = 0;
    public double minesLevel = 50;

    public float timer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            gold += (apprentices * apprenticeLevel);
            gold += (smithies * smithiesLevel);
            gold += (mines * minesLevel);
            timer += 1.0f;
        }
    }
}
