using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderAnim : MonoBehaviour
{
    
    public float time = 1f;
    public Animator animator;

    void Update()
    {
        animator.Play("Walking",-1,time);
    }

    public void AdjustFrame(float newTime)
    {
        time=newTime;
    }
    // public Animator animator;
    // [Range(0,1)]

    
    // public float tick;

    // void Start()
    // {
    //     animator.speed = 0f;
    // }

    // void Update()
    // {
    //     animator.Play("Walking",-1,tick);
    // }
}
