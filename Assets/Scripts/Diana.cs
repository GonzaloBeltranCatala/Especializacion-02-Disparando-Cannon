using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{

    GameObject bala;

    GameObject manager;

    GameObject diana;

    int contador = 0;

    bool rotacion = false;


    // Start is called before the first frame update
    void Start()
    {
        bala = GameObject.FindGameObjectWithTag("Bala");

        diana = GameObject.FindGameObjectWithTag("Diana");

        manager = GameObject.FindGameObjectWithTag("Manager");


    }

    // Update is called once per frame
    void Update()
    {
        if (rotacion)
        {
            transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
        }
       

    }




    private void OnCollisionEnter(Collision collision)
    {
        contador++;

        //destruye la bala al tocar la diana
        Destroy(collision.gameObject);

        GameManager.DisminuirBala();

        /* Practica 3
        if (contador == 1)
        {
            diana.GetComponent<Renderer>().material.color = Color.yellow;
        }

        else if (contador == 2)
        {
            rotacion = true;
        }

        else if (contador == 3)
        {
            Destroy(diana);

            GameManager.AumentarDiana();
  
        }
        */

        //Destruye la diana

        GameManager.AumentarDiana();

        manager.GetComponent<GameManager>().GenerarDiana();

        Destroy(gameObject);

        

       


    }

    

}
