using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Detecta el input de las teclas 'A' o 'D' para mover al Player
    void Update()
    {
        float _horizontalInput = Input.GetAxis("Horizontal");
        if ( _horizontalInput!= 0)
        {
            transform.position += new Vector3(_horizontalInput, 0,0) * Time.deltaTime * 10;
        }
    }
}
