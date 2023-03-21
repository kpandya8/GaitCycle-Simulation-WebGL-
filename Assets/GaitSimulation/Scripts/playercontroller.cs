using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]

public class playercontroller : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody _rigidbody;

    private bool _running;
    private bool _walking;
    private bool _dying;
    void Start()
    {
        _animator =GetComponent<Animator>();
        _rigidbody =GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
