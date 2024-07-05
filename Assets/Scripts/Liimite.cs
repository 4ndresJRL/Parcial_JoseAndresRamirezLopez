using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liimite : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
        }
    }
}
