using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            //Reproduce el audio de muerte y reicicia la escena
            AudioManager.instance.Play("Impacto");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
