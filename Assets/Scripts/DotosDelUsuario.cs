using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int edadUsuario;
    public float alturaUsuario;
    public bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + ", tengo" + edadUsuario + "años y mido " + alturaUsuario + " metros y es " + esDonante + " que soy donante.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
