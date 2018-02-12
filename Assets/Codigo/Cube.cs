using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Puntos puntos;

     void OnCollisionEnter()
    {
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPunto();
    }
}
