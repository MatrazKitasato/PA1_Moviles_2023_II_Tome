using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreFinal : MonoBehaviour
{
    public TextMeshProUGUI score_final;
    int newscore;
    public Transform content;
    public ScoreList scores;

    void Start()
    {
        newscore = Mathf.FloorToInt(GameManager.Instance.ships1.score);
        score_final.text = newscore.ToString();
        GameManager.Instance.scorelist.score.Add(newscore);
        for(int i = 0; i < GameManager.Instance.scorelist.score.Count; i++)
        {
            scores.text_score.text = GameManager.Instance.scorelist.score[i].ToString();
            Instantiate(scores, content);
        }
        
    }
}
