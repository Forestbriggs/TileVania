using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 20f;
    Rigidbody2D myRigidBody;
    PlayerMovement player;
    float xSpeed;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
        transform.localScale = new Vector2(Mathf.Sign(player.transform.localScale.x), 1f);
    }

    void Update()
    {
        myRigidBody.velocity = new Vector2(xSpeed, 0f);
    }
}
