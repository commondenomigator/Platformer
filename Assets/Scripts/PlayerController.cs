using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D RB;
    public float Speed = 5f;
    public float JumpPower = 8f;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) {
            Debug.Log("Jump!");
            RB.velocity = new Vector2(0, JumpPower);
        }

        RB.velocity = new Vector2(Input.GetAxis("Horizontal") * Speed, RB.velocity.y);
    }
}
