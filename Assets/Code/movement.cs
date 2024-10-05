using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 transformScale;


    [SerializeField] private float speed;
    private Rigidbody2D body;
    private bool grounded;
   
   private void Awake() {
    body = GetComponent<Rigidbody2D>();
   }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(horizontalInput*speed , body.velocity.y);
        if (horizontalInput > 0.01f)
        {
            Vector3 newScale = transformScale;
            newScale.x = Mathf.Abs(transformScale.x);
            transform.localScale = newScale;
        }
        else if (horizontalInput < -0.01f)
        {
            Vector3 newScale = transformScale;
            newScale.x = -Mathf.Abs(transformScale.x); 
            transform.localScale = newScale;
        }

        if(Input.GetKey(KeyCode.Space) && grounded) {
            Jump();
        }
    }
    private void Jump() {
        body.velocity = new Vector2(body.velocity.x, speed/2);
        grounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
