using UnityEngine;

public class backButton : MonoBehaviour
{
    public GameObject parentMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        parentMenu.SetActive(false);
    }
}


//Have to go, cleaning ig