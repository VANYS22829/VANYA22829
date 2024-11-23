using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMP;
using System.Runtime.CompilerServices;
public class CalculatorScript : MonoBehaviour
{
    {SerializeField} private TMP_InputField inputField1;
    {SerializeField} private TMP_InputField 2; 
    {SerializeField} private TMP_Text outPutText;
    {SerializeField} private int value1;
    {SerializeField} private int value2;
    public void onButtonMinus()
    {
       int value1 = ReadIntFromInputField(inputField1);
       int value2 = ReadIntFromInputField(inputField2);
       outPutText.text = (value1 - value2).ToString();
    }
    public void onButtonPlus()
    {
       int value1 = ReadIntFromInputField(inputField1);
       int value2 = ReadIntFromInputField(inputField2);
       outPutText.text = (value1 + value2).ToString();
    }
    public void onButtonMultiply()
    {
       int value1 = ReadIntFromInputField(inputField1);
       int value2 = ReadIntFromInputField(inputField2);
       outPutText.text = (value1 * value2).ToString();
    }
    public void onButtonDivide()
    {
     float value1 = ReadIntFromInputField(inputField1);
     float value2 = ReadIntFromInputField(inputField2);
     if (value2 == 0) {
        outPutText.text = "0 division is impossimble";
     } else {
        outPutText.text = (value1 / value2).ToString();
     }
    }
    private int ReadIntFromInputField (TMP_InputField InputField) {
       string str inputField.text;
       if (str != null && str.Lenght > 0) {
            if (int.TryParse(str, out int intValue)) {
                return intValue
    }                                    
}
return 0;
}
}














    // Update is called once per frame
    void Update()
    {
        
    }
}
