using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPool : MonoBehaviour
{
    public List<GameObject> objectsprefab;
    public List<GameObject> listobjects = new List<GameObject>();

    public GameObject GetObject()
    {
        GameObject objects = null;

        int random = Random.Range(0, objectsprefab.Count);

        foreach(GameObject b in listobjects)
        {
            if(!b.activeInHierarchy)
            {
                objects = b;
                break;
            }
        }

        if(objects == null)
        {
            objects = Instantiate(objectsprefab[random]);
            listobjects.Add(objects);
        }

        objects.SetActive(true);
        return objects;
    }

    public void ReturnObject(GameObject objects)
    {
        if(objects != null && objects.activeInHierarchy)
        {
            objects.SetActive(false);
        }
    }
}
