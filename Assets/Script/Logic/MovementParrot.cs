using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementParrot : MonoBehaviour
{
    public float forceMovement = 0.5f;

    private Vector2 playerPosition;

    public GameObject objSpriteMovement;
    private Animator animationSprite;


    private void Start()
    {
        if (objSpriteMovement != null)
            animationSprite = objSpriteMovement.GetComponent<Animator>();
    }


    private void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");

        if (objSpriteMovement != null)
        {
            switch (movementY)
            {
                case 1: animationSprite.SetBool("AnimationParrot2", true); break;
                case -1: animationSprite.SetBool("AnimationParrot2", false); break;
            }
        }

        playerPosition = transform.position;

        playerPosition = playerPosition + new Vector2(movementX, movementY) * forceMovement * Time.deltaTime;

        transform.position = playerPosition;

        StartCoroutine(MovementGravity());
    }

    IEnumerator MovementGravity()
    {
        yield return new WaitForSeconds(5f);
    }
}
