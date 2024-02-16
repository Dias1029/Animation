using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movSpeed;
    private float xAxis;
    private const string WALK_ANIMATION = "Walk";
    // private const string IDLE_ANIMATION = "Idle";
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
        Animate();
    }

    private void Move()
    {
        xAxis = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(xAxis, 0f, 0f) * Time.deltaTime * movSpeed;
    }

    private void Animate()
    {
        if (xAxis == 1 || xAxis == -1)
        {
            _anim.SetBool(WALK_ANIMATION, true);
        }
        else
        {
            _anim.SetBool(WALK_ANIMATION, false);   
        }
    }
}
