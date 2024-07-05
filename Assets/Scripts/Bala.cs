using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Papa : MonoBehaviour
{
    private Puntos score;
    private GameObject Contador;
    [SerializeField] private Transform partM;

    private void Start()
    {
        Contador = GameObject.Find("Text (TMP)");
        score = Contador.GetComponent<Puntos>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemigo"))
        {
            AudioManager.instance.Play("Impacto");
            AudioManager.instance.Play("Explosion");
            score.puntaje++;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}

