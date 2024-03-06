using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWithCage : MonoBehaviour
{
    public GameObject objMage;
    public Contador contador;
    public GameObject objectShow;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cage")
        {
            Destroy(objMage);
            objectShow.gameObject.SetActive(true);
            contador.contador++;

            if(contador.contador == 4)
            {
                contador.contador = 0;
                SceneManager.LoadScene("FinalScene");
            }            
        }
    }

}
