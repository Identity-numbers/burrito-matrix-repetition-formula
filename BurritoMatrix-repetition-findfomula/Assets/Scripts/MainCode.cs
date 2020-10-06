using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCode : MonoBehaviour
{
    public MainInterface mainInterface;

    private void Start()
    {
        //show initialization
        AddInput("Begin...", false);
        //commense calculation
        BeginCalc();
        //end
        AddInput("End...", true);
    }

    private void BeginCalc()
    {
        for (int atBM = 2; atBM < 1000; atBM += 2)
        {
            int atRow = 0;
            int atColumn = 2;
            int didRepeat = 1; //first row always present

            while (atRow < atBM - 1)
            {
                while (atColumn < atBM)
                {
                    atRow++;
                    if (atColumn == atBM / 2 + 1)
                    {
                        atColumn = atBM;
                    }
                    else
                    {
                        atColumn = (atColumn - 1) * 2 + 1;
                    }
                }

                if (atColumn > atBM)
                {
                    atColumn = 2 * atBM - atColumn + 1;
                }
                else
                {
                    atColumn = 2 * (atBM - atColumn + 1);
                }

                if (atColumn == 2)
                {
                    atRow++; 
                    if (atRow < atBM)
                    {
                        didRepeat++;
                    }
                }
            }
            //AddInput("at Burrito Matrix size: " + atBM + " First row Repeated: " + didRepeat);
            AddInput(didRepeat + ", ", false);
        }
    }
    private void AddInput(string str, bool useLineBreak = true)
    {
        mainInterface.AddInput(str, useLineBreak);
    }
}