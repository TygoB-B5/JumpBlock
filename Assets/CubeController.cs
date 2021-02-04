using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float Speed;
    public float jumpForce;
    public Rigidbody player;
    private bool canJump;
    void Update()
    {
        player.transform.Translate(Speed * Time.smoothDeltaTime, 0f, 0f);


        if (Input.GetKeyDown(KeyCode.Space))
            {

            if (canJump == true)
            {
                
                player.velocity = new Vector3(0f, jumpForce, 0f);
            }
        }
    }

    void OnCollisionStay(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("Respawn"))
        {
            player.transform.Translate(-Speed * Time.smoothDeltaTime, 0f, 0f);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}
