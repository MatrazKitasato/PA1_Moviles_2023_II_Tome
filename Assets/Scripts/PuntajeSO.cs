using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "puntaje", menuName = "Score")]
public class PuntajeSO : ScriptableObject 
{
    public List<int> score;
}
