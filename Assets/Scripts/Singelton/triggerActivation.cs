using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerActivation : MonoBehaviour
{
    SingeltonManager singeltonManager;
    private void Awake()
    {
        singeltonManager = FindObjectOfType<SingeltonManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            singeltonManager.changeCameraUp();
        }
    }
}
