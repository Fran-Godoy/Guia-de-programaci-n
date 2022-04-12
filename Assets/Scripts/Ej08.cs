using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("el Dia es Domingo");
                break;
            case 2:
                Debug.Log("el Dia es Lunes");
                break;
            case 3:
                Debug.Log("el Dia es Martes");
                break;
            case 4:
                Debug.Log("el Dia es Miercoles");
                break;
            case 5:
                Debug.Log("el Dia es Jueves");
                break;
            case 6:
                Debug.Log("el Dia es  Viernes");
                break;
            case 7:
                Debug.Log("el Dia es Sabado");
                break;
            default:
                Debug.Log(" El dia ingresado no es valido");
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
