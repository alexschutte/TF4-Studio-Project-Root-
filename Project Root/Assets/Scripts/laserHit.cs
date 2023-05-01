using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserHit : MonoBehaviour
{
 void OnCollisionEnter(Collision other)
 {
            if (other.gameObject.tag == "enemie")
           {
                    Destroy (gameObject);
           }
 }
}
