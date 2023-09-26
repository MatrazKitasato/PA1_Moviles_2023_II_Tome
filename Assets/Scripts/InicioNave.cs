using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioNave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int indexNave = PlayerPrefs.GetInt("NaveIndex");
        Instantiate(GameManager.Instance.ships[indexNave].ship, transform.position, Quaternion.identity);
    }
}
