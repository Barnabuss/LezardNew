using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lezard : MonoBehaviour
{

    private Vector2 _direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            _direction = Vector2.left;

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _direction = Vector2.down;

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _direction = Vector2.right;

        }
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
            );
    }
}
