using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public float monto1, monto2, monto3;
    public string persona1, persona2, persona3;
    // Start is called before the first frame update
    void Start()
    {
        float res;
        res = (monto1 + monto2 + monto3);
        Debug.Log(persona1 + " aportó " + monto1 + ", eso seria el " + (monto1 * 100 / res) + " % de los " + res + "aportados");
        Debug.Log(persona2 + " aportó " + monto2 + ", eso seria el " + (monto2 * 100 / res) + " % de los " + res + "aportados");
        Debug.Log(persona3 + " aportó " + monto3 + ", eso seria el " + (monto3 * 100 / res) + " % de los " + res + "aportados");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
