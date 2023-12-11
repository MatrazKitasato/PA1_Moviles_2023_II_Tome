using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public void ChangeScene(int n)
    {
        SceneManager.LoadScene(n);
        
    }
    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
