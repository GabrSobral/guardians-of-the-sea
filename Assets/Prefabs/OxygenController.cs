using UnityEngine;
using UnityEngine.UI;

public class Oxygen : MonoBehaviour
{
    [SerializeField]
    private float oxygenTime = 5;

    [SerializeField]
    private float oxygenProgress;

    [SerializeField]
    private Slider oxygenSlider;

    private void Awake()
    {
        oxygenSlider.maxValue = oxygenTime;
        oxygenSlider.minValue = 0;

        oxygenSlider.value = oxygenTime;
        oxygenProgress = oxygenTime;

        oxygenSlider.transform.position = new Vector3(transform.position.x, transform.position.y + 15, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (oxygenSlider.value != 0)
        {
            oxygenSlider.value -= Time.deltaTime;
        }

        if (oxygenSlider.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
