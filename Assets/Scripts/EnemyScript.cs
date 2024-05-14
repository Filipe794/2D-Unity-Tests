using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    
    void Start (){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        isGrounded =  Physics2D.OverlapCircle(groundCheck.position, checkRadius,whatIsGround);
    }
}
