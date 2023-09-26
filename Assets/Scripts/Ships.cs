using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Naves", menuName = "Nave")]
public class Ships : ScriptableObject
{
    public GameObject ship;

    public Sprite image;

    public string name;

    public float speed;

}
