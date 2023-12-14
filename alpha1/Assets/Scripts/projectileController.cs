using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileController : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


      // OnTriggerEnter is called when the GameObject collides with another GameObject
    void OnTriggerEnter(Collider other)
    {
          if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject); // Destroy the enemy when colliding with the player's projectile
            // You might want to add some additional functionality here such as score increment or effects.
        }
    }       
}
