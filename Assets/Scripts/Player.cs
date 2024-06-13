using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 25f;

    [SerializeField]
    private float oxygenTime = 15;

    [SerializeField]
    private Slider oxygenSlider;

    private void Awake()
    {
        oxygenSlider.maxValue = oxygenTime;
        oxygenSlider.minValue = 0;

        oxygenSlider.value = oxygenTime;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new(moveHorizontal, moveVertical, 0f);

        transform.position += moveSpeed * Time.deltaTime * movement;

        oxygenSlider.transform.position = new Vector3(transform.position.x, transform.position.y + 15, transform.position.z);

        if (oxygenSlider.value  != 0)
        {
            oxygenSlider.value -= Time.deltaTime;
        }

        if(oxygenSlider.value <= 0)
        {
            ResetGame();
        }

        if (moveHorizontal < 0)
        {
            oxygenSlider.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            transform.localScale = new Vector3(20, 10, 10);
        }   
        else if (moveHorizontal > 0)
        {
            oxygenSlider.transform.localScale = new Vector3(-0.2f, 0.2f, 0.2f);
            transform.localScale = new Vector3(-20, 10, 10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Colidiu com " + collider.gameObject.name);
        Destroy(collider.gameObject);

        if (collider.gameObject.name == "Oxygen(Clone)")
        {
            oxygenSlider.value += 10;
        }
        Destroy(collider.gameObject);
    }

    private void ResetGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
