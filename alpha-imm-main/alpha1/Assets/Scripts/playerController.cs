using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float speed = 5.0f;
    public float spawnOffset = 10f; // Offset distance from the player

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Calculate spawn position slightly in front of the player
            Vector3 spawnPosition = transform.position + transform.forward * spawnOffset;

            // Instantiate the projectile at the calculated spawn position
            Instantiate(projectilePrefab, spawnPosition, transform.rotation);
        }

        // Get user input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction based on user input
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;

        // Apply movement to the player's position
        transform.Translate(movement);
    }
}
