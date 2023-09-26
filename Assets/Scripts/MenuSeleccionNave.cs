using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionNave : MonoBehaviour
{
    private int index;
    public Image imagen;
    public TextMeshProUGUI nombrenave;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("NaveIndex");

        CambiarPantalla();

        if(index > gameManager.ships.Count - 1)
        {
            index = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("NaveIndex", index);
        imagen.sprite = gameManager.ships[index].image;
        nombrenave.text = gameManager.ships[index].name;
    }
    public void SiguientePersonaje()
    {
        if(index == gameManager.ships.Count - 1)
        {
            index = 0;
        }
        else
        {
            index++;
        }
        CambiarPantalla();
    }
    public void AnteriorPersonaje()
    {
        if (index == 0)
        {
            index = gameManager.ships.Count - 1;
        }
        else
        {
            index--;
        }
        CambiarPantalla();
    }
    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
