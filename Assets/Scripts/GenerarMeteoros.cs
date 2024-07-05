using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemerarMeteoros : MonoBehaviour
{
    [SerializeField] GameObject Meteoritos;

    [SerializeField] private float limiteIzq;
    [SerializeField] private float limiteDer;
    [SerializeField] private float tiempo;

    private float spawnX;

    private void Start()
    {
        InvokeRepeating("Spawner", 0f, tiempo);
    }

    private void Spawner()
    {
        spawnX = Random.Range(limiteIzq, limiteDer);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);
        Instantiate(Meteoritos, spawnPosition, Quaternion.identity);
    }
}
