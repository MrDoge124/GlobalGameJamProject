using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z +1));
        rb.gravityScale = 0;
        print("a");
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z +1));
        print("b");
    }

    private void OnMouseUp()
    {
        rb.gravityScale = 1;
        rb.velocity = new Vector2 (0,0);
        print("c");
    }
}
