using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonManager : MonoBehaviour
{
    public static SingeltonManager Instance { get; private set; }
    public Camera cam;
    private void Awake()
    {
        if (Instance == null && Instance != this)
        {
            Destroy(this);
        }
        else 
        { 
            Instance = this;
        }
        //Esto hace que solo exista un singelton y que sea el el mismo singelton si es algun otro lo destruye
    }
   
    public void changeCameraUp()
    {
        cam.transform.position = new Vector3(cam.transform.position.x + 17, cam.transform.position.y, -10);
    }
    //esta funcion hace que la camara cambie para ajustarce a donde esta el jugador en el mapa
}
