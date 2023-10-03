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
    public PuntajeSO puntajes;
    public Transform content;
    public ScoreList scores;

    void Start()
    {
        newscore = Mathf.FloorToInt(GameManager.Instance.ships1.score);
        puntajes.score.Add(newscore);
        for(int i = 0; i <=puntajes.score.Count; i++)
        {
            scores.text.text = newscore.ToString();
            Instantiate(scores, content);
        }
    }
}
