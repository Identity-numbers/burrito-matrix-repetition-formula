using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainInterface : MonoBehaviour
{
    public InputField inputField;

    public void AddInput(string str, bool useLinebreak = true)
    {
        if (useLinebreak)
        {
            inputField.text += "\n" + str ;
        }
        else
        {
            inputField.text += str;
        }
    }
}
