using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryDriver : MonoBehaviour
{
    [SerializeField] private float steerSpeed=300f;
    [SerializeField] private float moveSpeed=20f;
    [SerializeField] private float boostSpeed=10f;
    [SerializeField] private float slowSpeed=30f;
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
}
