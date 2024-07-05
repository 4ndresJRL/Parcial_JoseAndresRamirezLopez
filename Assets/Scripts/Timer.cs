using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float contador; //Establece el valor a poner en el contador
    private TextMeshProUGUI tiempoTexto; //Se usa para escribir en el TextMeshPro

    private void Start()
    {
        //Manda a llamar el metodo
        Inicializar();
    }
    private void Update()
    {
        //Manda a llamar el metodo
        Temporizador();
    }
    private void Inicializar()
    {
        //Le da el componente a la variable
        tiempoTexto = GetComponent<TextMeshProUGUI>();
    }
    private void Temporizador()
    {
        //Establece que la variable es igual al tiempo en aumento
        contador += Time.deltaTime;
        //Establece el contenido del TextMeshPro
        tiempoTexto.text = "Tiempo 0" + contador.ToString("f0");
    }
}
