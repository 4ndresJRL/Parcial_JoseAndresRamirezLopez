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
            AudioManager.instance.Play("Impacto");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
