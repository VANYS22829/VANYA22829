using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameText; 
    public TMP_InputField ageInputField;
    public TMP_Text ageText;

    // Update is called once per frame
    public void OnButtonUserName()
    {
        nameText.text = nameInputField.text;
    }

    public void OnButtonUserAge()
    {
        string ageString = ageInputField.text;
         int ageInt = int.Parse(ageString);     
        System.DateTime dt = System.DateTime.Now;
        // dt.AddYears(DateTime.)
    }
}
