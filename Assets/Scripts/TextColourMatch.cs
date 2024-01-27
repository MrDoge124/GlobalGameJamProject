using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextColourMatch : MonoBehaviour
{
    GameObject memeRoot;
    // Start is called before the first frame update
    void Start()
    {
        memeRoot = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (memeRoot.GetComponent<Image>().color == Color.black)
        {
            GetComponent<Image>().color = Color.black;
            foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.color = Color.white;
            }
           
        }
        if (memeRoot.GetComponent<Image>().color == Color.white)
        {
            GetComponent<Image>().color = Color.white;
            foreach (TextMeshProUGUI text in GetComponentsInChildren<TextMeshProUGUI>())
            {
                text.color = Color.black;
            }

        }
    }
}
