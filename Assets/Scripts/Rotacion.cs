using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(300f, 0f, 300f) * Time.deltaTime);
    }
}
