using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meme
{
    public bool topText;
    public Color borderCol = Color.black; //black or white
    public int imageTheme; //caps out at 3 //people 0, animals 1, food 2, misc 3.
    public int fryStage; //caps out at 3 //normal 0, cooked, 1, crispy 2, burnt 3.
    public int imageSize; //caps out at 2 // square 0, tall 1, wide 2.
    //all start from 0

    public Meme CreateMeme(bool text, Color c, int it,int fs, int imS)
    {
        Meme newMeme = new Meme();
        newMeme.topText = text;
        newMeme.borderCol = c;
        newMeme.imageTheme = imageTheme;
        newMeme.fryStage = fs;
        newMeme.imageSize = imS;
        return newMeme;
    }
    public Meme CreateRandomMeme()
    {
        Meme newMeme = new Meme();

        int boolnum = Random.Range(1, 10);
        if (boolnum <= 5)
        {
            newMeme.topText = true;
        }
        else
        {
            newMeme.topText = false;
        }
        int randCol = Random.Range(1, 10);
        if (randCol <= 4)
        {
            newMeme.borderCol = Color.black;
        }
        else if (randCol >= 5)
        {
            newMeme.borderCol = Color.white;
        }
        int randTheme = Random.Range(0, 3);
        newMeme.imageTheme = randTheme;

        int randFry = Random.Range(0, 3);
        newMeme.fryStage = randFry;

        int randSize = Random.Range(0, 2);
        newMeme.imageSize = randSize;

        return newMeme;
    }
}
