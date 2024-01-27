using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableComponent : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]bool isText;
    [SerializeField]bool isPaint;
    BlankMemeScript BMeme;
    private void Start()
    {
        BMeme = GameObject.FindGameObjectWithTag("BlankMeme").GetComponent<BlankMemeScript>();
        print(BMeme.name);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (isText)
            {
                if (collision.CompareTag("TopText"))
                {
                    print("Top!");
                    BMeme.top = true;
                    BMeme.bottom = false;
                    BMeme.TextCheck();
                    Destroy(this.gameObject, 0.1f);
                }
                else if (collision.CompareTag("BottomText"))
                {
                    print("Bottom!");
                    BMeme.top = false;
                    BMeme.bottom = true;
                    BMeme.TextCheck();
                    Destroy(this.gameObject, 0.1f);
                }
            }
            if (isPaint) 
            {
                if (collision.CompareTag("ColourTrigger"))
                {
                    if (this.CompareTag("WhitePaint"))
                    {
                        BMeme.ColourChange(Color.white);
                        Destroy(this.gameObject, 0.1f);
                    }
                    if (this.CompareTag("BlackPaint"))
                    {
                        BMeme.ColourChange(Color.black);
                        Destroy(this.gameObject, 0.1f);
                    }
                }
            }
        }
    }
}
