using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Papa : MonoBehaviour
{
    private Puntos score;//Cuenta los puntos y los guarda en el puntaje
    private GameObject contador;//Busca el game object de la variable puntos

    private void Start()
    {
        //Manda a llamar el metodo
        Inicializar();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemigo"))
        {
            //Reproduce los sonidos de impacto del proyectil, la destrucción del meteorito
            //suma puntos
            //Destruye ambos objetos
            AudioManager.instance.Play("Impacto");
            AudioManager.instance.Play("Explosion");
            score.puntaje++;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    private void Inicializar()
    {
        //Le da sus propiedades ambas variables
        contador = GameObject.Find("Text (TMP)");
        score = contador.GetComponent<Puntos>();
    }
}

