using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lezard : MonoBehaviour
{

    private Vector3 _direction ;
    private float speed = 0.10f;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up*speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down*speed;
        }
    }

   //rivate void FixedUpdate()
   //
     // this.transform.position = new Vector3(
       //   Mathf.Round(this.transform.position.x) + _direction.x,
         // Mathf.Round(this.transform.position.y) + _direction.y,
           //.0f
           //;
    //
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mur")
        {

            print("boinjouyr");
        }
    }
}
