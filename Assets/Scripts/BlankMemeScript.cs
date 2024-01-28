using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlankMemeScript : MonoBehaviour
{
    [SerializeField]GameObject topText, bottomText, image, baseSquare, baseTall, baseWide;
    public Sprite memeImage;
    [SerializeField] MenuManager mMan;
    Color bordercolour;
    public bool top, bottom;
    public int rollCountTall = 0;
    public int rollCountWide = 0;
    // Start is called before the first frame update
    void Start()
    {
        ResetMeme();
    }
    public void ResetMeme()
    {
        topText.SetActive(false);
        bottomText.SetActive(false);
        image.SetActive(false);
        baseSquare.SetActive(true);
        baseTall.SetActive(false);
        baseWide.SetActive(false);
    }
    private void Update()
    {
        if (rollCountTall >= 5)
        {
            baseSquare.SetActive(false);
            baseTall.SetActive(true);
            mMan.SetSize(1);
        }
        if (rollCountWide >= 5)
        {
            baseSquare.SetActive(false);
            baseWide.SetActive(true);
            mMan.SetSize(2);
        }
        if (rollCountTall >= 5 && rollCountWide >= 5)
        {
            rollCountTall = 0;
            rollCountWide = 0;
            baseSquare.SetActive(true);
            baseWide.SetActive(false);
            baseTall.SetActive(false);
            mMan.SetSize(0);
        }
    }
    public void SetCook(int fry) 
    {
        mMan.SetFry(fry);
        if (fry == 0)
        {
            image.GetComponent<Image>().sprite.texture.mipMapBias = 0;
        }
        if (fry == 1)
        {
            image.GetComponent<Image>().sprite.texture.mipMapBias = 2;
        }
        if (fry == 2)
        {
            image.GetComponent<Image>().sprite.texture.mipMapBias = 5;
        }
    }
    public void ChangeTheme(int themeID)
    {
        mMan.SetTheme(themeID);
        image.SetActive(true);
        image.GetComponent<Image>().sprite = memeImage;
    }
    public void TextCheck()
    {
        if (top)
        {
            topText.SetActive(true);
            bottomText.SetActive(false);
            mMan.SetText(true);
        }
        if (bottom)
        {
            topText.SetActive(false);
            bottomText.SetActive(true);
            mMan.SetText(false);
        }
    }
    public void ColourChange(Color c)
    {
        baseSquare.GetComponent<Image>().color = c;
        baseTall.GetComponent<Image>().color = c;
        baseWide.GetComponent<Image>().color = c;
        mMan.Setcol(c);
    }
}
