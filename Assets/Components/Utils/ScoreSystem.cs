using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem Instance;
    public float _score;

    [Space]
    [Header("Score Text")]
    public TextMeshProUGUI _scoreText;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        _score = Mathf.Clamp(_score, 0f, 9999.999f);
        _scoreText.text = _score.ToString();
    }
}
