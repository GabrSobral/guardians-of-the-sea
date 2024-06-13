using UnityEngine;
using UnityEngine.UI;

public class Trash : MonoBehaviour
{
    [SerializeField]
    private int _score;

    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreController>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trash Colidiu com " + collider.gameObject.name);

        _scoreController.AddScore(_score);
    }
}
