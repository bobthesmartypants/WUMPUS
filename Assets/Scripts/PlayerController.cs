using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Debug.Log(rb.velocity.x + ", " + rb.velocity.y);

        if (Mathf.Sign(moveHorizontal) * Mathf.Sign(rb.velocity.x) > 0)
        {
            rb.AddForce(new Vector2(moveHorizontal, 0) * speed);
        }
        else
        {
            rb.AddForce(new Vector2(moveHorizontal, 0) * 2 * speed);
        }
        if (Mathf.Sign(moveVertical)*Mathf.Sign(rb.velocity.y) > 0)
        {

            rb.AddForce(new Vector2(0, moveVertical) * speed);
        }
        else
        {
            rb.AddForce(new Vector2(0, moveVertical) * 2 * speed);
        }

    }
}
