using System.Collections;
using System.Collections.Generic;
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
    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(true);
        //userMeme = new Meme().CreateMeme(userText,userCol,userTheme,userFry,userSize);
    }
    public void NextCustomer()
    {
        customerMeme = new Meme().CreateRandomMeme();
        print("Customer Text = " + customerMeme.topText);
        print("Customer border colour = " + customerMeme.borderCol);
        print("Customer Image Theme = " + customerMeme.imageTheme);
        print("Customer Fry Stage = " + customerMeme.fryStage);
        print("Customer Image Size = " + customerMeme.imageSize);
        nextButton.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
