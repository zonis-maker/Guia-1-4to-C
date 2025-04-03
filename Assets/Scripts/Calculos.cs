using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos : MonoBehaviour
{
    public int num1;
    public int num2;
    public int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
