using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using TMPro;
using System;
public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField1;
    [SerializeField] private TMP_InputField inputField2; 
    [SerializeField] private TMP_Text outPutText;
    [SerializeField] private float value1;
    [SerializeField] private float value2;
    public void onButtonMinus()
    {
       float value1 = ReadFloatFromInputField(inputField1);
       float value2 = ReadFloatFromInputField(inputField2);
       outPutText.text = (value1 - value2).ToString();
    }
    public void onButtonPlus()
    {
       float value1 = ReadFloatFromInputField(inputField1);
       float value2 = ReadFloatFromInputField(inputField2);
       outPutText.text = (value1 + value2).ToString();
    }
    public void onButtonMultiply()
    {
       float value1 = ReadFloatFromInputField(inputField1);
       float value2 = ReadFloatFromInputField(inputField2);
       outPutText.text = (value1 * value2).ToString();
    }
    public void onButtonDivide()
    {
     float value1 = ReadFloatFromInputField(inputField1);
     float value2 = ReadFloatFromInputField(inputField2);
     if (value2 == 0) {
        outPutText.text = "0 division is impossimble";
     } else {
        outPutText.text = (value1 / value2).ToString();
     }
    }

float ReadFloatFromInputField(object inputField2)
{
    throw new NotImplementedException();
}

private float ReadFloatFromInputField (TMP_InputField inputField) {
       string str = inputField.text;
       if (str != null && str.Length > 0) {
            if (float.TryParse(str, out float floatValue)) {
                return floatValue;
    }                                    
}
return 0;
}
}

