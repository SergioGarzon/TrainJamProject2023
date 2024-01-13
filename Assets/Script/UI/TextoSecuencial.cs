using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoSecuencial : MonoBehaviour
{
    public Text textoUI;
    private string textoCompleto;
    public float velocidadEscritura = 0.1f;

    private void Start()
    {
        textoCompleto = "'Que un elefante ocupa mucho espacio lo sabemos todos. Pero que un elefante de circo se decidi� una vez a pensar 'en elefante', esto es a tener una idea tan enorme como su cuerpo... Ah, eso algunos no lo saben'.";

        // Inicia la escritura secuencial cuando se carga el script
        StartCoroutine(EscribirTextoSecuencial());
    }

    IEnumerator EscribirTextoSecuencial()
    {
        // Aseg�rate de que el Texto no sea nulo
        if (textoUI == null)
        {
            yield break;
        }

        // Aseg�rate de que el TextoCompleto no sea nulo o vac�o
        if (string.IsNullOrEmpty(textoCompleto))
        {
            yield break;
        }

        // Limpia el Texto antes de empezar a escribir
        textoUI.text = "";

        // Itera a trav�s de cada letra en el texto completo
        for (int i = 0; i < textoCompleto.Length; i++)
        {
            // Agrega la letra actual al texto del UI
            textoUI.text += textoCompleto[i];

            // Espera un tiempo antes de agregar la siguiente letra
            yield return new WaitForSeconds(velocidadEscritura);
        }
    }
}
