using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameManager gameMan;
    [SerializeField] GameObject orderMenu;
    [SerializeField] GameObject imageMenu;
    [SerializeField] GameObject cookMenu;
    // Start is called before the first frame update
    void Start()
    {
        orderMenu.SetActive(true);
        imageMenu.SetActive(false);
        cookMenu.SetActive(false);
    }
    public void ShowMenu(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void HideMenu(GameObject obj)
    {
        obj.SetActive(false);
    }
    public void SetText(bool state)
    {
        gameMan.userText = state;
        print("User text = " + gameMan.userText);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
