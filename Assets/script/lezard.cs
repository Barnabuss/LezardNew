using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lezard : MonoBehaviour
{
    private List<Transform> _segments;
    public Transform tete;
    public float speed = 0.20f;
    public Transform segmentPrefab;
    private void Start()
    {
        _segments = new List<Transform>();
        _segments.Add(this.transform);
    }

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

    private void FixedUpdate()
    {
        for (int i = _segments.Count-1;i>0;i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mur")
        {

            print("boinjouyr");
        }
    }
    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab, new Vector3(tete.position.x - 1, tete.position.y - 1, 0));
        segment.position = _segments[_segments.Count - 1].position;
        _segments.Add(segment);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bouffe")
        {



            Debug.Log("oscur");
            Destroy(gameObject);

        }
    }
}
