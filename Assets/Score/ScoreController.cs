using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private GameObject modalPanel;

    public int Score {get; private set;}

    public UnityEvent OnScoreChange;

    public void AddScore(int amount)
    {
        Score += amount;

        Debug.Log(Score);

        OnScoreChange.Invoke();

        if(Score == 20)
        {
            Time.timeScale = 0f;
            modalPanel.SetActive(true);
        }
    }
}
