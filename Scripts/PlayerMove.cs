using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public LayerMask layerMask;
    public bool Grounded;
    public float moveSpeed = 6;
    public float jumpForce = 12;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //input
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //moving
        Vector3 movePos = transform.right * x + transform.forward * y;
        Vector3 newMovePos = new Vector3(movePos.x, rb.velocity.y, movePos.z);

        rb.velocity = newMovePos;

        //grounding
        Grounded = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y-1, transform.position.z), 0.4f, layerMask);

        //jumping
        if(Input.GetKeyDown(KeyCode.Space) && Grounded) {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
    }
}
