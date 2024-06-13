using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    private TMP_Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }

    public void UpdateScore(ScoreController scoreController)
    {
        Debug.Log(scoreController);
        _scoreText.text = $"Score: {scoreController.Score}/20";
    }
}
