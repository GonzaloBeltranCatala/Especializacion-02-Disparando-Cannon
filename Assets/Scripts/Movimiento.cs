using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    GameObject cruceta;

    Vector3 movimiento;

    // Start is called before the first frame update
    void Start()
    {
        cruceta = GameObject.Find("Cruceta");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            Mover(1);

        }

        if (Input.GetKey("a"))
        {
            Mover(2);
        }

        if (Input.GetKey("s"))
        {
            Mover(3);
        }

        if (Input.GetKey("d"))
        {
            Mover(4);
        }


        

    }

    public void Mover(int opcion)
    {
       

        movimiento = cruceta.transform.position;

        float posicionX = movimiento.x;

        float posicionY = movimiento.y;

        float posicionZ = movimiento.z;

        switch (opcion)
        {
            case 1:

                posicionY++;

                break;

            case 2:

                posicionX--;

                break;

            case 3:

                posicionY--;

                break;

            case 4:

                posicionX++;

                break;


            default:
                break;
        }

        

        Vector3 nuevaPosicion = new Vector3(Mathf.Clamp(posicionX, -25f, 25f), Mathf.Clamp(posicionY, -1f, 20f), posicionZ);


        cruceta.transform.position = nuevaPosicion;

    }
}
