using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionWithAnimals : MonoBehaviour
{
    public GameObject panel0;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    public Text txtSpeakPlayer0;
    public Text txtSpeakPlayer1;
    public Text txtSpeakPlayer2;
    public Text txtSpeakPlayer3;

    private bool control;

    private void Start()
    {
        control = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Duck")
        {
            OcultarInformacion();

            panel0.gameObject.SetActive(true);
            panel2.gameObject.SetActive(true);

            txtSpeakPlayer0.text = "!¿Te volviste loco?! ¿De que encierro hablas?";
            txtSpeakPlayer2.text = "¿Acaso los seres humanos tolerarian que hagamos lo mismo con ellos?";

            control = true;
        }

        if (collision.gameObject.tag == "Bear")
        {
            OcultarInformacion();

            panel1.gameObject.SetActive(true);
            panel2.gameObject.SetActive(true);

            txtSpeakPlayer1.text = "¿Cómo te quejas cuando nos dan techo y comida?";
            txtSpeakPlayer2.text = "¿No te das cuenta? \r\n Naciste en cautiverio, desplazado de tu tierra y tu familia. Solo conoces el circo y no la dicha";

            control = true;
        }

        if (collision.gameObject.tag == "Kangaroo")
        {
            OcultarInformacion();

            panel3.gameObject.SetActive(true);
            panel2.gameObject.SetActive(true);

            txtSpeakPlayer3.text = "¿Libres? ¿De que?";
            txtSpeakPlayer2.text = "¿Crees que somos libres entre tus ordenes y barrotes? Libertad es poder elegir donde y cómo vivir";

            control = true;
        }

        if (collision.gameObject.tag == "Parrot")
        {
            if (control)
            {
                OcultarInformacion();

                panel2.gameObject.SetActive(true);

                txtSpeakPlayer2.text = "!Ay! Con que suspender la función... Mmm ¿,esto puede interesarle al resto, ¿. ¡Me voy! Tengo mensaje que entregar.";

                StartCoroutine(CorrutinaNuevaEscena());
            }            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Duck")        
            OcultarInformacion();        

        if (collision.gameObject.tag == "Bear")        
            OcultarInformacion();        

        if (collision.gameObject.tag == "Kangaroo")        
            OcultarInformacion();

        if (collision.gameObject.tag == "Parrot")
            OcultarInformacion();
    }


    public void OcultarInformacion()
    {
        panel0.gameObject.SetActive(false);
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(false);
        panel3.gameObject.SetActive(false);

        txtSpeakPlayer0.text = "";
        txtSpeakPlayer1.text = "";
        txtSpeakPlayer2.text = "";
        txtSpeakPlayer3.text = "";
    }


    IEnumerator CorrutinaNuevaEscena()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("CageParrotScene");
    }

}
