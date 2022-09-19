using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamwalk_Movement : MonoBehaviour
{

    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    public GameObject dreamwalk;


    Vector2 movement;

    // Start is called before the first frame update
    private void Start()
    {
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





    }


}
