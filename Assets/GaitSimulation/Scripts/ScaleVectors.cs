using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScaleVectors : MonoBehaviour
{
    public TMP_InputField value;

    // private float nextActionTime = 0.0f;
    public float period = 0.1f;
    Vector3 temp;
    // Start is called before the first frame update
  
    // Update is called once per frame
    public void recalculate()
    {
       
            float vec;
            vec = float.Parse(value.text);
            Debug.Log(vec);

            temp = transform.localScale;
            temp.y = Mathf.Min(20f,(vec / 50));
            transform.localScale = temp;
    

    }
}
