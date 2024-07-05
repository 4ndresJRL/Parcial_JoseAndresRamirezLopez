using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private CharacterController ctrl;
    private float movX;
    [SerializeField] private float vel;
    private Vector3 movi;

    private void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }
    private void Update()
    {
        movi = transform.right * movX;
        ctrl.Move(movi * vel * Time.deltaTime);

        movX = Input.GetAxis("Horizontal");
    }
}
