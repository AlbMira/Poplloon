using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : Singleton<ScoreSystem>
{
    public int _score;

    [Space]
    [Header("Score Text")]
    public TextMeshProUGUI _scoreText;

    private void Update()
    {
        _scoreText.text = _score.ToString();
    }
}
