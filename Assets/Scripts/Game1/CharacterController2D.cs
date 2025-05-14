using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D myRigidbody2D;
    private Vector2 direction;

    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        myRigidbody2D.velocity = new Vector3(speed * direction.x, speed * direction.y);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
}