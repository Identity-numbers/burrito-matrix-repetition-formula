using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCode : MonoBehaviour
{
    public MainInterface mainInterface;
    public BurritoMatrix36 burritoMatrix36;

    private int[][] Matrix36;

    private void Start()
    {
        //load up matrixse
        Matrix36 = burritoMatrix36.Matrix36;
        //show initialization
        AddInput("Begin...", false);

        //commense calculation
        BeginCalc();

        //end
        AddInput("End...", false);
    }

    private void BeginCalc()
    {
        int atCurrentBurrito;

        for (atCurrentBurrito = 8; atCurrentBurrito < 8; atCurrentBurrito += 2)
        {

            //zerobased array
            int atIndex = 2;
            int atRow = 0;
            int didRepeat = 1;//first row

            while (atRow < atCurrentBurrito - 1)
            {
                //count up formula 2^n while sum smaller than matrix size
                while (atIndex < atCurrentBurrito)
                {
                    //AddInput(atIndex + ", ");
                    atRow++;
                    atIndex = (atIndex - 1) * 2 + 1;
                }
                //AddInput("atindex before reduction: " + atIndex + ", ");
                //reset indexvalue to correct value
                if (atIndex > atCurrentBurrito)
                {
                    atIndex -= (atIndex - 1) / 2;
                }

                //cacluate next index
                atIndex = (atCurrentBurrito - atIndex) * 2 + 2;
                //atRow++;

                if (atIndex == 2)
                {
                    didRepeat++;
                }
            }
            AddInput("atCurrentBurrito: " + atCurrentBurrito + " DidRepeat: " + didRepeat);

            //if not the number will get a new index at first half of sequence and accelerate depending on sizenumber
        }
    }
    
    //shorten the function call
    private void AddInput(string str, bool useLineBreak = true)
    {
        mainInterface.AddInput(str, useLineBreak);
    }

}