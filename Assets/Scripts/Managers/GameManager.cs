using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Meme customerMeme;
    Meme userMeme;
    int currentMenu = 0; //0 ordering //1 image //2 cook
    [SerializeField] GameObject nextButton;
    public bool userText;
    public Color userCol;
    public int userTheme;
    public int userFry;
    public int userSize;
    float totalScore = 0;
    [SerializeField] AudioSource BellRing; 
    [SerializeField] TextMeshProUGUI customerText;
    [SerializeField] GameObject customerObj;
    [SerializeField] GameObject Blank;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(true);
        customerObj.SetActive(false);
        userMeme = new Meme().CreateMeme(userText,userCol,userTheme,userFry,userSize);
    }
    public void NextCustomer()
    {
        BellRing.Play(0);
        customerMeme = new Meme().CreateRandomMeme();
        customerObj.SetActive(true);
        print("Customer Text = " + customerMeme.topText);
        print("Customer border colour = " + customerMeme.borderCol);
        print("Customer Image Theme = " + customerMeme.imageTheme);
        print("Customer Fry Stage = " + customerMeme.fryStage);
        print("Customer Image Size = " + customerMeme.imageSize);
        nextButton.SetActive(false);
        customerText.text = CustomerSpeech();
    }
    public void ResetGame()
    {
        Start();
        Blank.GetComponent<BlankMemeScript>().ResetMeme();
    }
    string CustomerSpeech()
    {
        string result = "";
        string textState = "";
        string bordercolText = "";
        string themeText = "";
        string fryText = "";
        string sizeText = "";
        if (customerMeme.topText)
        {
            textState = "Top Text";
        }
        else
        {
            textState = "Bottom Text";
        }
        if (customerMeme.borderCol == Color.white)
        {
            bordercolText = "White";
        }
        if (customerMeme.borderCol == Color.black)
        {
            bordercolText = "Black";
        }
        if (customerMeme.imageTheme == 0)
        {
            themeText = "People";
        }
        if (customerMeme.imageTheme == 1)
        {
            themeText = "Animal";
        }
        if (customerMeme.imageTheme == 2)
        {
            themeText = "Food";
        }
        if (customerMeme.imageTheme == 3)
        {
            themeText = "Misc";
        }
        if (customerMeme.fryStage == 0)
        {
            fryText = "No frying";
        }
        if (customerMeme.fryStage == 1)
        {
            fryText = "Cooked";
        }
        if (customerMeme.fryStage == 2)
        {
            fryText = "Crispy";
        }
        if (customerMeme.imageSize == 0)
        {
            sizeText = "Square";
        }
        if (customerMeme.imageSize == 1)
        {
            sizeText = "Tall";
        }
        if (customerMeme.imageSize == 2)
        {
            sizeText = "Wide";
        }
        return result = (textState + ", " + bordercolText + ", " + themeText + ", " + fryText + ", " + sizeText);
        //This pretty much reads the results and sets the strings. It then joins them together in the result string.
        //That's what is displayed.
    }
    public float CompareMeme(Meme m1, Meme m2)
    {
        float score = 0;
        if (m1.topText == m2.topText)
        {
            score++;
        }
        else
        {
            score--;
        }
        if (m1.borderCol == m2.borderCol)
        {
            score++;
        }
        else
        {
            score--;
        }
        if (m1.imageTheme == m2.imageTheme)
        {
            score++;
        }
        else
        {
            score--;
        }
        if (m1.imageSize == m2.imageSize)
        {
            score++;
        }
        else
        {
            score--;
        }
        return score;
    }
    public void Results()
    {
        totalScore += CompareMeme(customerMeme,userMeme);
        print("total score = " +totalScore);
    }

}
