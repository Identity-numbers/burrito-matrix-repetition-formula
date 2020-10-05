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
        for (int atBM = 4; atBM < 36; atBM += 2)
        {
            //AddInput("===== doing number: " + atCurrentBurrito);
            int atRow = 0;
            int atColumn = 2;
            int didRepeat = 1; //first row always present

            while (atRow < atBM - 1)
            {
                while (atColumn < atBM)
                {
                    atRow++;
                    //AddInput("atIndex: " + atIndex + ", atRow: " + atRow);
                    if (atColumn == atBM / 2 + 1)
                    {
                        atColumn = atBM;
                    }
                    else
                    {
                        atColumn = (atColumn - 1) * 2 + 1;
                    }
                }
                //AddInput("atindex before reduction: " + atIndex + ", ");
                //reset index value to correct value
                if (atColumn > atBM)
                {
                    atColumn -= (atColumn - 1) / 2;
                    atColumn = (atBM - atColumn) * 2 + 2;
                }else{
                    atColumn = (atBM - atColumn) * 2 + 2;
                }
                //AddInput("atindex after reduction: " + atIndex + ", ");
                if (atColumn == 2)
                {
                    atRow++;
                    if (atRow < atBM)
                    {
                        didRepeat++;
                        //AddInput("atRow: " + atRow + " didRepeat: " + didRepeat);
                    }
                }
            }
            AddInput("at Burrito Matrix size: " + atBM + " First row Repeated: " + didRepeat);
        }
    }
    private void AddInput(string str, bool useLineBreak = true)
    {
        mainInterface.AddInput(str, useLineBreak);
    }
}