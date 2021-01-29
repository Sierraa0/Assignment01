using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public string TypeName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        TypeName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + TypeName + " to the game.";
    }
}
