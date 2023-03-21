using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inspaceUI : MonoBehaviour
{
    public TMP_InputField vectorX;
    public TMP_InputField vectorY;
    public TMP_InputField vectorZ;
    public TextMeshProUGUI outputX;
    public TextMeshProUGUI outputY;
    public TextMeshProUGUI outputZ;


    public void UIOutput(){
        float vecX, vecY, vecZ;
            vecX = float.Parse(vectorX.text);
            Debug.Log(vecX);
            vecY = float.Parse(vectorY.text);
            Debug.Log(vecY);
            vecZ = float.Parse(vectorZ.text);
            Debug.Log(vecZ);

        outputX.text = vectorX.text + " " + "kgs";
        outputY.text = vectorY.text + " " + "m/s^2";
        outputZ.text = vectorZ.text + " " + "Degrees";
    }
}