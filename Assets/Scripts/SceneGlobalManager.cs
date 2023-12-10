using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneGlobalManager : MonoBehaviour
{
    public EventSystem a;
    public Scene _scene;
    void Start()
    {
        Invoke("ChangeSceneAdditive", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSceneAdditive()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
        a.gameObject.SetActive(false);
    }
}
