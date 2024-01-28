using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextColourMatch : MonoBehaviour
{
    [SerializeField]GameObject memeRootSquare, memeRootTall, memeRootWide;

    // Update is called once per frame
    void Update()
    {
        if (memeRootSquare.GetComponent<Image>().color == Color.black || memeRootTall.GetComponent<Image>().color == Color.black || memeRootWide.GetComponent<Image>().color == Color.black)
        {
            GetComponent<Image>().color = Color.black;
            foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.color = Color.white;
            }
           
        }
        if (memeRootSquare.GetComponent<Image>().color == Color.white || memeRootTall.GetComponent<Image>().color == Color.white || memeRootWide.GetComponent<Image>().color == Color.white)
        {
            GetComponent<Image>().color = Color.white;
            foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.color = Color.black;
            }

        }
    }
}
