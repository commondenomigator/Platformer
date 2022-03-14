using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CapsuleCollider2D CC;
    Rigidbody2D RB;
    public float Speed = 5f;
    public float JumpPower = 8f;
    public Vector2 StartPosition = new Vector2(0, 0);
    public float Boundary = -10f;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        CC = GetComponent<CapsuleCollider2D>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && CC.IsTouchingLayers()) {
            Debug.Log("Jump!");
            RB.velocity = new Vector2(0, JumpPower);
        }

        RB.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, RB.velocity.y);

        if (transform.position.y < Boundary) {
            Reset();
        }
    }

    void Reset()
    {
        transform.position = StartPosition;
        RB.velocity = Vector2.zero;
    }
}
