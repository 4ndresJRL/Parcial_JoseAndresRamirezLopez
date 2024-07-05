using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMeteoros : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            //Destruye los meteoros al llegar a cierto punto
            Destroy(collision.gameObject);
        }
    }
}
