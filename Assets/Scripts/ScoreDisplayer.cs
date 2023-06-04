using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDisplayer : MonoBehaviour
{
    private static int score = 0;
    // Start is called before the first frame update
    public static TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    void Start()
    {
        ScoreDisplayer.text = text2;
        text.text = "Score: 0";
        score = 0;
    }

    public static void AddScore(int count)
    {
        score += count;
        text.text = "Score: " + score;
        if (score >= 20)
        {
            SceneManager.LoadScene(2);
        }
    }
    public static void RemoveScore(int count)
    {
        score -= count;
        text.text = "Score: " + score;
        if (score <0)
        {
            SceneManager.LoadScene(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
