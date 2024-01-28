using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableComponent : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]bool isText;
    [SerializeField]bool isPaint;
    [SerializeField]bool isPin;
    [SerializeField]bool isMemeImage;
    BlankMemeScript BMeme;

    private void Start()
    {
        BMeme = GameObject.FindGameObjectWithTag("BlankMeme").GetComponent<BlankMemeScript>();
        print(BMeme.name);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0))
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
                if (collision.CompareTag("BottomText"))
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
            if (collision.CompareTag("ColourTrigger"))
            {
                if (isMemeImage)
                {
                    if (this.CompareTag("PeopleImage"))
                    {
                        BMeme.ChangeTheme(0);
                        Destroy(this.gameObject, 0.1f);
                    }
                    if (this.CompareTag("AnimalImage"))
                    {
                        BMeme.ChangeTheme(1);
                        Destroy(this.gameObject, 0.1f);
                    }
                    if (this.CompareTag("FoodImage"))
                    {
                        BMeme.ChangeTheme(2);
                        Destroy(this.gameObject, 0.1f);
                    }
                    if (this.CompareTag("MiscImage"))
                    {
                        BMeme.ChangeTheme(3);
                        Destroy(this.gameObject, 0.1f);
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPin)
        {
            if (collision.CompareTag("SideTrigger"))
            {
                BMeme.rollCountWide++;
                print(BMeme.rollCountWide);
            }
            if (collision.CompareTag("BottomText"))
            {
               BMeme.rollCountTall++;
                print(BMeme.rollCountTall);
            }
            if (collision.CompareTag("TopText"))
            {
                BMeme.rollCountTall++;
                print(BMeme.rollCountTall);
            }
        }
    }
}
