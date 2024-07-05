using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private float enfriando;
    [SerializeField] private GameObject balas;
    [SerializeField] private float fuerza;
    private bool puedeDisparar = true;

    void Update()
    {
        Disparar();
    }

    private void Disparar()
    {
        if (Input.GetMouseButtonDown(0) && puedeDisparar == true)
        {
            AudioManager.instance.Play("Disparo");
            GameObject clon = Instantiate(balas, transform.GetChild(0).position, transform.GetChild(0).rotation);
            clon.GetComponent<Rigidbody>().AddForce(transform.GetChild(0).forward * fuerza);
            Destroy(clon, 3);
            StartCoroutine(Enfriamiento());
        }
    }

    private IEnumerator Enfriamiento()
    {
        puedeDisparar = false;
        yield return new WaitForSeconds(enfriando);
        puedeDisparar = true;
    }
}
