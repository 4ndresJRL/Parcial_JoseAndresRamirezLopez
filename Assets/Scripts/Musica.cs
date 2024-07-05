using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Aparece la clase en el inspector dentro del audiomanager
[System.Serializable]
public class Musica
{
    //Se establecen las variables a tomar encuentra en los efectos de sonido
    public string nombre;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
