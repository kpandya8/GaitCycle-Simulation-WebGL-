using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class avatarselect : MonoBehaviour
{
    public void Male()
    {
        SceneManager.LoadScene("Male_Gait");
    }
//    public void Female()
//     {
//         SceneManager.LoadScene("Female_Gait");
//     }
//     public void Child()
//     {
//         SceneManager.LoadScene("Child_Gait");
//     }
   
}
