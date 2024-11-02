using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameText; 
   
    // Update is called once per frame
    public void OnButtonUserName()
    {
        nameText.text = nameInputField.text;
    }
}
