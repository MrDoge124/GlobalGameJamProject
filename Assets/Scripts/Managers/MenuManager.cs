using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [Header("Managers")]
    [SerializeField] GameManager gameMan;
    [SerializeField] MemeImage images;//Meme image lists
    [Header("Menu Objects")]
    [SerializeField] GameObject orderMenu;
    [SerializeField] GameObject imageMenu, imageMenu2;
    [SerializeField] GameObject cookMenu;
    [SerializeField] GameObject blank;
    [Header("Image Objects")]
    [SerializeField] GameObject PeopleImage;
    [SerializeField] GameObject AnimalImage;
    [SerializeField] GameObject FoodImage;
    [SerializeField] GameObject MiscImage; //Image prefabs
    // Start is called before the first frame update
    void Start()
    {
        orderMenu.SetActive(true);
        imageMenu.SetActive(false);
        imageMenu2.SetActive(false);
        cookMenu.SetActive(false);
        blank.SetActive(false);
    }
    public void ShowMenu(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void HideMenu(GameObject obj)
    {
        obj.SetActive(false);
    }
    #region meme settings
    public void SetText(bool state)
    {
        gameMan.userText = state;
        print("User text = " + gameMan.userText);
    }
    public void Setcol(Color col)
    {
        gameMan.userCol = col;
        print("User colour = " + gameMan.userCol);
    }
    public void SetTheme(int themeID)
    {
        gameMan.userTheme = themeID;
        print("User theme = " + gameMan.userTheme);
    }
    public void SetFry(int fry)
    {
        gameMan.userFry = fry;
        print("User fry = " + gameMan.userFry);
    }
    public void SetSize(int ImgSize)
    {
        gameMan.userSize = ImgSize;
        print("User size = " + gameMan.userSize);
    }
    #endregion
    public void CreateObjectImageMenu(GameObject obj)
    {
        Instantiate(obj,imageMenu.transform);
    }
    public void CreateMemeImage(int themeID)
    {
        if (themeID == 0)
        {
            GameObject newobj = Instantiate(PeopleImage, cookMenu.transform);
            newobj.GetComponent<Image>().sprite = images.peopleSprite[Random.Range(0, images.peopleSprite.Length)];
            blank.GetComponent<BlankMemeScript>().memeImage = newobj.GetComponent<Image>().sprite;
        }
        if (themeID == 1)
        {
            GameObject newobj = Instantiate(AnimalImage, cookMenu.transform);
            newobj.GetComponent<Image>().sprite = images.animalSprite[Random.Range(0, images.animalSprite.Length)];
            blank.GetComponent<BlankMemeScript>().memeImage = newobj.GetComponent<Image>().sprite;
        }
        if (themeID == 2)
        {
            GameObject newobj = Instantiate(FoodImage, cookMenu.transform);
            newobj.GetComponent<Image>().sprite = images.foodSprite[Random.Range(0, images.foodSprite.Length)];
            blank.GetComponent<BlankMemeScript>().memeImage = newobj.GetComponent<Image>().sprite;
        }
        if (themeID == 3)
        {
            GameObject newobj = Instantiate(MiscImage, cookMenu.transform);
            newobj.GetComponent<Image>().sprite = images.miscSprite[Random.Range(0, images.miscSprite.Length)];
                        blank.GetComponent<BlankMemeScript>().memeImage = newobj.GetComponent<Image>().sprite;
        }
    }
}
