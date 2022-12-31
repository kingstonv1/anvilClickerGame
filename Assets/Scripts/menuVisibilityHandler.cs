using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuVisibilityHandler : MonoBehaviour
{
    //The objects in this array are as follows:
    //shopMenu, abilitiesMenu, statsMenu, settingsMenu
    public GameObject[] menus = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        //Iterates through the objects in the menus array
        for(int i = 0; i < 4; i++) 
        {
            menus[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
