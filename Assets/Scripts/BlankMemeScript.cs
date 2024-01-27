using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlankMemeScript : MonoBehaviour
{
    [SerializeField]GameObject topText, bottomText, image;
    Color bordercolour;
    public bool top, bottom;
    // Start is called before the first frame update
    void Start()
    {
        topText.SetActive(false);
        bottomText.SetActive(false);
        image.SetActive(false);
        bordercolour = Color.white;
    }

    public void TextCheck()
    {
        if (top)
        {
            topText.SetActive(true);
            bottomText.SetActive(false);
        }
        if (bottom)
        {
            topText.SetActive(false);
            bottomText.SetActive(true);
        }
    }
    public void ColourChange(Color c)
    {
        this.GetComponent<Image>().color = c;
    }
}
