using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* 
 * Proper equation to solve for is Joint Reaction Force (JRF) -> F = m*g*cos(x) where x is the angle
 * between the ground and incline surface.
 */
 
public class JRFCalculate : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public TMP_InputField x;

    public TMP_InputField y;

    Vector3 xaxis;
    public TMP_InputField z;
    public TMP_InputField massInput;
    public TMP_InputField coefficientInput;
    public TMP_InputField angleInput;
    public Button playButton;
    public TMP_Text resultText;
    
    void Start()
    {
        playButton.onClick.AddListener(CalculateJointReactionForce);
    }

    public void CalculateJointReactionForce()
    {
        
        float mass;
        float coefficient;
        float angle;
        float result;

        // Reads in values from inputs fields
        anim.SetBool("Idle", false);
        anim.SetBool("Dying", false);
        anim.SetBool("Walking", true);
        anim.SetBool("Running", false);
        mass = float.Parse(massInput.text);
        coefficient = float.Parse(coefficientInput.text);
        angle = float.Parse(angleInput.text);
        if( mass >= 5 && mass <= 400 && angle >= 0 && angle <= 180 ){
         // Calculates the JRf and then prints out answer in Newtons
        result = mass * Mathf.Cos(angle * Mathf.Deg2Rad) * coefficient;
        resultText.text = "Joint Reaction Force: " + result.ToString("F2") + " N";
        Debug.Log("Result: " + resultText.text);
    }
    else{
        resultText.text = "The Inputs seem to be out of bounds, please check the input parameters. ";
        anim.SetBool("Idle", false);
        anim.SetBool("Dying", true);
        anim.SetBool("Walking", false);
        anim.SetBool("Running", false);
    }
       
    }
   
}
