using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1); 
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1); 
    [SerializeField] float destroyDelay = 0.05f;
    SpriteRenderer spriteRenderer;

    void Start() {
       spriteRenderer = GetComponent<SpriteRenderer>();
    }
   void OnCollisionEnter2D(Collision2D other) 
   {
       Debug.Log("Ouch!!");
      
   }
    void OnTriggerEnter2D(Collider2D other) 
    {
     if(other.tag == "Package" && !hasPackage){
        Debug.Log("Package Picked");
        hasPackage = true;
        spriteRenderer.color = hasPackageColor;
        Destroy(other.gameObject, destroyDelay);
     }
     if(other.tag == "Customer" && hasPackage){
        Debug.Log("Package Delivered!!!");
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
     }
   }
}
