using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopMenu : MonoBehaviour
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
        //checks to see if any other menus are open before opening the shop menu
        if (!menus.menus[1].active && !menus.menus[2].active && !menus.menus[3].active)
        {
            menu.SetActive(true);
        }
    }
}
