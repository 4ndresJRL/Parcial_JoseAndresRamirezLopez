using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private float enfriando; //Da un tiempo entre disparo y disparo
    [SerializeField] private GameObject balas; //El Game Object de la bala
    [SerializeField] private float fuerza; //La fuerza con la que va la bala
    private bool puedeDisparar = true;

    void Update()
    {//Manda a llamar el metodo
        Disparar();
    }

    private void Disparar()
    {
        if (Input.GetMouseButtonDown(0) && puedeDisparar == true)
        { 
            AudioManager.instance.Play("Disparo"); //Reproduce el sonido de las balas
            GameObject clon = Instantiate(balas, transform.GetChild(0).position, transform.GetChild(0).rotation);
            clon.GetComponent<Rigidbody>().AddForce(transform.GetChild(0).forward * fuerza); //Aparece las balas donde son llamadas
            Destroy(clon, 3); //Destruye el objeto al cierto tiempo 
            StartCoroutine(Enfriamiento()); //Manda a llamar el metodo
        }
    }

    private IEnumerator Enfriamiento()
    {
        //Evita que el disparo se realice inmediatamente
        puedeDisparar = false; 
        yield return new WaitForSeconds(enfriando);
        puedeDisparar = true;
    }
}
