using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPickedUpPackage=false;
    [SerializeField] private float destroyWaitTime=0.5f;
    [SerializeField] private Color32 hasPackageColor=new Color32(1,1,1,1);
    [SerializeField] private Color32 noPackageColor=new Color32(1,1,1,1);

    private SpriteRenderer spriteRenderer;
    private void Start() {
        spriteRenderer= GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        // Debug.Log("Collided with an obstacle!");
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Package" && !hasPickedUpPackage) {
            hasPickedUpPackage=true;
            Debug.Log("Picked up the package.");
            spriteRenderer.color=hasPackageColor;
            Destroy(other.gameObject, destroyWaitTime);
        } else if(other.tag=="Customer" && hasPickedUpPackage) {
            hasPickedUpPackage=false;
            Debug.Log("Delivered the package to the customer.");
            spriteRenderer.color=noPackageColor;
        }
    }
}
