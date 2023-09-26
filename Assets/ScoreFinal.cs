using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreFinal : MonoBehaviour
{
    public TextMeshProUGUI score_final;
    int highscore = 0;
    int newscore;

    void Start()
    {
        newscore = Mathf.FloorToInt(GameManager.Instance.ships1.score);
        if (highscore < newscore)
        {
            score_final.text = "Puntaje Final: " + newscore;
        }
        highscore = newscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
