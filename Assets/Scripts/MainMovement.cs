using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovement : MonoBehaviour
{
    private MainController controller;
    private Rigidbody2D movementrigidBody;

    private Vector2 movementDirection = Vector2.zero;

    private Camera camera;

    private void Awake()
    {
        controller = GetComponent<MainController>();
        movementrigidBody = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        //TODO : 캐릭터 속도 스탯 넣어줘야함
        movementrigidBody.velocity = direction;
    }

}
