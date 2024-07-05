using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteBalas : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Proyectil"))
        {
            //Destruye las balas a partir de cierto punto
            Destroy(collision.gameObject);
        }
    }
}
