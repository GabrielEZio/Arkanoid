using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

    public static int vidas = 3;
    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;

	// Use this for initialization
	void Start () {
        textoVidas.text = "Vidas: " + Vidas.vidas;
	}
	
	// Update is called once per frame
	public void PerderVida()
    {
        if (vidas <= 0) return;

        Vidas.vidas--;
        textoVidas.text = "Vidas: " + Vidas.vidas;

        if (vidas <= 0)
        {
            //Mostraremos GameOver
            gameOver.SetActive(true);
            pelota.detenerMovimiento();
            barra.enabled = false;
            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();

        }
        else
        {
            barra.Reset();
            pelota.Reset();
        }
       
       

            
    }
}
