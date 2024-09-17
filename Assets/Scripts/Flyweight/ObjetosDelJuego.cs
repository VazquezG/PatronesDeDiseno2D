using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosDelJuego : MonoBehaviour
{
    public GuardarImagen scriptableObject;

    private SpriteRenderer spriteImage;
    private void Awake()
    {
        spriteImage = GetComponent<SpriteRenderer>();
        spriteImage.sprite = scriptableObject.sprite;
    }
}
