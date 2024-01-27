using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        rb.gravityScale = 0;
        print("a");
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        print("b");
    }

    private void OnMouseUp()
    {
        rb.gravityScale = 1;
        rb.velocity = new Vector2 (0,0);
        print("c");
    }
}
