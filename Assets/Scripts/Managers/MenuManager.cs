using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameManager gameMan;
    [SerializeField] GameObject orderMenu;
    [SerializeField] GameObject imageMenu, imageMenu2;
    [SerializeField] GameObject cookMenu;
    [SerializeField] GameObject blank;
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
}
