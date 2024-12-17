using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public GameObject textoBalas;

    static public GameObject textoDianas;

    static public GameObject textoPotencia;

    static int numBala = 0;

    static int numDiana = 0;

    static int numPotencia = 0;

    int numAleatorio;

    int aleatorioAnterior;

    GameObject[] posicionesDiana;

    public GameObject diana;


    void Start()
    {
        textoBalas = GameObject.Find("NumBala");

        textoDianas = GameObject.Find("NumDianas");

        textoPotencia = GameObject.Find("NumPotencia");


        //mover diana a una posicion aleatoria
        posicionesDiana = GameObject.FindGameObjectsWithTag("Respaw");

        numAleatorio = Random.Range(0, posicionesDiana.Length - 1);

        aleatorioAnterior = numAleatorio;

        Instantiate(diana, posicionesDiana[numAleatorio].transform.position, diana.transform.rotation);



    }

    public void GenerarDiana()
    {
        //cada vez que la diana se destruya aparecera otra

        posicionesDiana = GameObject.FindGameObjectsWithTag("Respaw");

        //no repetir la misma posicion
        numAleatorio = Random.Range(0, posicionesDiana.Length - 1);

        while (numAleatorio == aleatorioAnterior)
        {
            numAleatorio = Random.Range(0, posicionesDiana.Length - 1);
        }

        //crea diana
        Instantiate(diana, posicionesDiana[numAleatorio].transform.position, diana.transform.rotation);

        aleatorioAnterior = numAleatorio;

    }

    

    static public void ResetBala()
    {
        numBala = 0;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();
    }

    static public void AumentarBala()
    {
        numBala++;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();


    }

    static public void DisminuirBala()
    {

        numBala--;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();

    }

    static public void AumentarDiana()
    {
        numDiana++;

        textoDianas.GetComponent<TextMeshProUGUI>().text = numDiana.ToString();



    }

    static public void AumentarPotencia()
    {
  
        numPotencia++;

        textoPotencia.GetComponent<TextMeshProUGUI>().text = numPotencia.ToString();


    }

    static public void ResetPotencia()
    {

        numPotencia = 0;

        textoPotencia.GetComponent<TextMeshProUGUI>().text = numPotencia.ToString();


    }

    static public int Potencia()
    {

        return int.Parse(textoPotencia.GetComponent<TextMeshProUGUI>().text);

    }




}
