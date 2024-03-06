using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float pushForce = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mage"))
        {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 pushDirection = (collision.transform.position - transform.position).normalized;
                rb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
            }
        }        
    }
}
