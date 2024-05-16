using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
private float horizontal;
private float speed = 8f;
private float jumpingPower = 16f;
private bool isFacingRight = true;

[SerializeField] private Rigidbody2D rb;
[SerializeField] private Transform groundcheck;
[SerialzeField] private LayerMask groundlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}