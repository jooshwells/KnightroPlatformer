using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 transformScale;


    [SerializeField] private float speed;
    private Rigidbody2D body;
   
   private void Awake() {
    body = GetComponent<Rigidbody2D>();
   }

    private void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector3(horizontalInput*speed , body.velocity.y);

        if(horizontalInput >0.01f) {
            transform.localScale = transformScale;
        }
        else if(horizontalInput <0.01f) {
            transform.localScale = transformScale;
        }

        if(Input.GetKey(KeyCode.Space)) {
            body.velocity = new Vector2(body.velocity.x, speed/2);
        }
    }
}
