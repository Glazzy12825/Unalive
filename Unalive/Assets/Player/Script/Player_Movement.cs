using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public GameObject player;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //input
      movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

    }

    //Update is called on a fixed timer
    private void FixedUpdate()
    {
        //movement
        
       
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        
        
    }
}
