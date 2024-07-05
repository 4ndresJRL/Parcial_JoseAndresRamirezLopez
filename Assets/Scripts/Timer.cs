using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float contador;
    private TextMeshProUGUI tiempoTexto;

    private void Start()
    {
        tiempoTexto = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        contador += Time.deltaTime;

        tiempoTexto.text = "Tiempo 0" + contador.ToString("f0");   
    }
}
