using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour {

    public float velocidadInicial = 800f;
    public Rigidbody rigid;

    bool enJuego = false;

    Vector3 posicionInicial;

    public Transform barra;

  

    // Use this for initialization
    void Start () {

        posicionInicial = transform.position;
	}

    public void Reset()
    {
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        rigid.isKinematic = true;
        rigid.velocity = Vector3.zero;
         
    }

    public void detenerMovimiento()
    {
        rigid.isKinematic = true;
        rigid.velocity = Vector3.zero;
    }


    // Update is called once per frame
    void Update () {
        if (!enJuego && Input.GetButtonDown("Fire1"))
        {
            enJuego = true;
            transform.SetParent(null);
            rigid.isKinematic = false;
            rigid.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));

        }



	}
}
