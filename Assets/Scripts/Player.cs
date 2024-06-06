using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new(moveHorizontal, moveVertical, 0f);
        transform.position += moveSpeed * Time.deltaTime * movement;


        if (movement != Vector3.zero)
        {
            // Calculate the angle between the current direction and the target direction
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;

            // Invert the direction by adding 180 degrees
            angle += 180f;

            // Apply the rotation
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Colidiu com " + collider.gameObject.name);
        Destroy(collider.gameObject);
    }
}
