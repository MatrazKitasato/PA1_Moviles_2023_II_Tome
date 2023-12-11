using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneGlobalManager : MonoBehaviour
{
    
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            Invoke("ChangeSceneAdditive", 3);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSceneAdditive()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(4);
        while (!asyncLoad.isDone && GameManager.Instance.ships1.life <= 0)
        {
            Debug.Log("Listo");
            yield return null;
        }
        
    }
    public void ChangeScene(int n)
    {
        
        Debug.Log("Cambiando a escena " + n);
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            Debug.Log("iniciando");
            //StartCoroutine(LoadYourAsyncScene());
            SceneManager.LoadSceneAsync(4);
        }
        SceneManager.LoadScene(n);

    }
    public void Quit()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
