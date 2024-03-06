using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionParrotWithAnimals : MonoBehaviour
{
    public Text txtNumber1;
    public Text txtNumber2;
    public Text txtNumber3;
    public Text txtNumber4;
    public Text txtNumber5;

    private int validador;

    private void Start()
    {
        validador = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tiger")
        {
            txtNumber1.gameObject.SetActive(true);
            validador = 1;
        }

        if (collision.gameObject.tag == "Bear")
        {
            txtNumber2.gameObject.SetActive(true);
            
            if (validador == 1)            
                validador = 2;
            else            
                validador = 0;            
        }

        if (collision.gameObject.tag == "Kangaroo")
        {
            txtNumber3.gameObject.SetActive(true);

            if (validador == 2)
                validador = 3;
            else
                validador = 0;
        }

        if (collision.gameObject.tag == "Duck")
        {
            txtNumber4.gameObject.SetActive(true);

            if (validador == 3)
                validador = 4;
            else
                validador = 0;
        }

        if (collision.gameObject.tag == "Lion")
        {
            txtNumber5.gameObject.SetActive(true);

            if (validador == 4)
            {
                validador = 5;
                SceneManager.LoadScene("MageScene");
            }
            else
                validador = 0;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tiger")        
            txtNumber1.gameObject.SetActive(false);
        

        if (collision.gameObject.tag == "Bear")        
            txtNumber2.gameObject.SetActive(false);
        

        if (collision.gameObject.tag == "Kangaroo")       
            txtNumber3.gameObject.SetActive(false);
        

        if (collision.gameObject.tag == "Duck")        
            txtNumber4.gameObject.SetActive(false);
        

        if (collision.gameObject.tag == "Lion")        
            txtNumber5.gameObject.SetActive(false);
        
    }

}
