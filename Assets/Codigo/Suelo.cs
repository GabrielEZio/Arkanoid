using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public Vidas vidasJugador;

     void OnTriggerEnter( )
    {
        vidasJugador.PerderVida();
    }
}
