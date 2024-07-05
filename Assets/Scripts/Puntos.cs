using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public int puntaje; //Se usa marcar los puntos en el TextMeshPro
    private TextMeshProUGUI textMesh; //Da acceso al TextMesh

    private void Start()
    {
        //Manda a llamar el metodo
        Inicializar();
    }

    private void Update()
    {
        //Manda a llamar el metodo
        Puntaje();
    }
    private void Inicializar()
    {
        //Le da el componente necesario a la variable
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Puntaje()
    {
        //Marca la variable en el TextMeshPro
        textMesh.text = "Puntaje 0" + puntaje;
    }
}
