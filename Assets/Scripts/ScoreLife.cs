using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreLife : MonoBehaviour
{
    public TextMeshProUGUI life;
    public TextMeshProUGUI score;

    void Start()
    {
        GameManager.Instance.ships1.score = 0;
        GameManager.Instance.ships1.life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.ships1.score += Time.deltaTime;
        score.text = "Score: " + Mathf.FloorToInt(GameManager.Instance.ships1.score);
        life.text = "Life: " + GameManager.Instance.ships1.life;
    }
}
