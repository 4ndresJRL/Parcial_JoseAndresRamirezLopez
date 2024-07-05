using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondomovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMov; //Perfila la movilidad
    private Vector2 offset; //Obitiene el valor
    private Material material; //Mueve el metodo con su offset

    private void Awake()
    {
        //Manda a llamar el metodo
        Inicializar();  
    }
    private void Update()
    {
        //Manda a llamar el metodo
        Movimiento();
    }

    private void Movimiento()
    {
        //Mueve el objeto
        offset = velocidadMov * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
    private void Inicializar()
    {
        //Da el componente
        material = GetComponent<SpriteRenderer>().material;
    }
}
