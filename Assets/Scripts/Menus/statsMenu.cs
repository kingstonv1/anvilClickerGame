using UnityEngine;

public class statsMenu : MonoBehaviour
{
    public GameObject menu;
    public MenuVisibilityHandler menus;

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
        //checks to see if any other menus are open before opening the abilities menu
        if (!menus.menus[0].active && !menus.menus[1].active && !menus.menus[3].active)
        {
            menu.SetActive(true);
        }
    }
}
