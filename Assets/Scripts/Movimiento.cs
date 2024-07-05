using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private CharacterController ctrl;//Variable para declarar el CharacterController
    private float movX;//Control
    [SerializeField] private float vel;//Velocidad
    private Vector3 movi;//Mueve el objeto

    private void Start()
    {
        //Manda a llamar el metodo
        Inicializar();
    }
    private void Update()
    {
        //Manda a llamar el metodo
        Moverse();
    }
    private void Moverse()
    {
        //Se le da acceso a la variable del control Horizontal "A&D"
        //Luego utilizando movi se calcula la dirección en base a la tecla y la orientacion del objeto
        //Finalmente se establece el movimiento usando el CharacterController
        movX = Input.GetAxis("Horizontal");
        movi = transform.right * movX;
        ctrl.Move(movi * vel * Time.deltaTime);
       
    }
    private void Inicializar()
    {
        //Da el componente a la varaible
        ctrl = GetComponent<CharacterController>();
    }
}
