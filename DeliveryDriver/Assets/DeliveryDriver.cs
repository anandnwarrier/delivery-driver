using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryDriver : MonoBehaviour
{
    [SerializeField] private float steerSpeed=300f;
    [SerializeField] private float moveSpeed=20f;
    [SerializeField] private float boostSpeed=50f;
    [SerializeField] private float slowSpeed =5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount= Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount= Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpeedBooster")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boosted speed:"+ moveSpeed.ToString());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
        Debug.Log("Slowed speed:" + moveSpeed.ToString());
    }
}
