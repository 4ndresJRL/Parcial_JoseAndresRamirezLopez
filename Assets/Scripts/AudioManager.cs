using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    //Manda a llamar la clase de musica
    public Musica[] music;

    private void Awake()
    {
        //Manda a llamar el metodo
        Intansce();
    }
    private void Start()
    {
        //Manda a llamar el metodo
        Establecer();
    }
    public void Play(string nombre)
    {
        //Establece la calse
        for (int i = 0; i < music.Length; i++)
        {
            if (nombre == music[i].nombre)
            {
                music[i].source.Play();
                return;
            }
        }
    }

    public void Step(string nombre)
    {
        //Reproduce la musica
        for (int i = 0; i < music.Length; i++)
        {
            if (nombre == music[i].nombre)
            {
                music[i].source.Stop();
                return;
            }
        }
    }

    private void Intansce()
    {
        //Evita la destruccion al cargar y permite almacenar scripts dentro
        //de él
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Establecer()
    {
        //Establece las variables de la musica
        for (int i = 0; i<music.Length; i++)
        {
            music[i].source = gameObject.AddComponent<AudioSource>();
            music[i].source.clip = music[i].clip;
            music[i].source.volume = music[i].volume;
            music[i].source.loop = music[i].loop;
        }
    }
}
