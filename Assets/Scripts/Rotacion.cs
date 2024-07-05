using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    private void FixedUpdate()
    {
        //Manda a llamar el metodo
        Rotar();
    }
    private void Rotar()
    {
        //Rota el objeto en los angulos X,Y,Z en ese orden, con la fuerza
        //Establecida en float
        transform.Rotate(new Vector3(300f, 0f, 300f) * Time.deltaTime);
    }
}
