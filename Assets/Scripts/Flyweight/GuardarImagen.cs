using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Imagen", menuName = "ScriplableObject/GuardarImagen", order = 1)]

public class GuardarImagen : ScriptableObject
{
    public string name;
    public Sprite sprite;
    //este scriptable object guarda imagenes para usar de referencia en los sprites del juego
}
