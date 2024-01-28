using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlankMemeScript : MonoBehaviour
{
    [SerializeField]GameObject topText, bottomText, image, baseSquare, baseTall, baseWide;
    Color bordercolour;
    public bool top, bottom;
    public int rollCountTall = 0;
    public int rollCountWide = 0;
    // Start is called before the first frame update
    void Start()
    {
        topText.SetActive(false);
        bottomText.SetActive(false);
        image.SetActive(false);
        bordercolour = Color.white;
        baseSquare.SetActive(true);
        baseTall.SetActive(false);
        baseWide.SetActive(false);
    }
    private void Update()
    {
        if (rollCountTall >= 5)
        {
            baseSquare.SetActive(false);
        }
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
        baseSquare.GetComponent<Image>().color = c;
        baseTall.GetComponent<Image>().color = c;
        baseWide.GetComponent<Image>().color = c;
    }
}
