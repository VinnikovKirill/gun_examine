using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject gun;
    public GameObject gun1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (gun.activeInHierarchy == true)
        {
            gun.SetActive(false);
            gun1.SetActive(true);
        }

        else
        {
            gun.SetActive(true);
            gun1.SetActive(false);
        }
            
    }
}
