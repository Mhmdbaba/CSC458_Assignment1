using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float player_speed = 10.0f;
    public float player_rotation_speed = 100.0f;

    public float jumpForce = 100.0f;
    private Rigidbody rigidPlayer;
    public float gravity;

    public bool isONGround = true;



    void Start()
    {
        rigidPlayer = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * player_speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * player_rotation_speed * Time.deltaTime;


        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);
        

        if (Input.GetKeyDown(KeyCode.Space) && isONGround){
            rigidPlayer.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isONGround = false;
        }

        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground")){
            isONGround = true;
        }
    }
}
