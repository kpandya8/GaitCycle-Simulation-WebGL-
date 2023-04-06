using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class panelToggle : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject Input_Panel;
        public GameObject Formula_Panel;


    public void uiToggle()
    {
        // Debug.Log("ToggleWorks");
        
        if(Input_Panel != null )
        {
            bool isActive = Input_Panel.activeSelf;
            Input_Panel.SetActive(!isActive);
        }
          if(Formula_Panel != null )
        {
            bool isActive = Formula_Panel.activeSelf;
            Formula_Panel.SetActive(!isActive);
        }
    }

    
}
