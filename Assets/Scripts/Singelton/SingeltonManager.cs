using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingeltonManager : MonoBehaviour
{
    public static SingeltonManager Instance { get; private set; }
    Camera cam;
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
        cam = FindAnyObjectByType<Camera>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void changeCameraUp()
    {
        cam.transform.position = new Vector3(cam.transform.position.x + 17, cam.transform.position.y, 0);
    }

    public void changeCameraDown()
    {
        cam.transform.position = new Vector3(cam.transform.position.x - 17, cam.transform.position.y, 0);
    }

}
