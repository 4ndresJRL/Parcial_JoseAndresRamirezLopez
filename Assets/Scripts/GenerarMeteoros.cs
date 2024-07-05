using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemerarMeteoros : MonoBehaviour
{
    [SerializeField] GameObject Meteoritos;//GameObject serializado para meter dentro de él el objeto a instancear

    [SerializeField] private float limiteIzq;//Maximo de generáción hacia la izquierda
    [SerializeField] private float limiteDer;//Maximo de generación hacia la drerecha
    [SerializeField] private float tiempo;//Variable entre meteoro y meteoro

    private float spawn;

    private void Start()
    {
        //Hace que el metodo llamado se repita cada que pase la misma cantidad de segundos que el
        //float tiempo tiene anotado
        InvokeRepeating("Spawner", 0f, tiempo);
    }

    private void Spawner()
    {
        //Basado en un random mueve el spawner en el rango establecido entre las variables
        //limiteIzq y limiteDer
        //Luego se instancean meteoritos en donde este el spawner
        spawn = Random.Range(limiteIzq, limiteDer);
        Vector3 spawnPosition = new Vector3(spawn, transform.position.y, 0f);
        Instantiate(Meteoritos, spawnPosition, Quaternion.identity);
    }
}
