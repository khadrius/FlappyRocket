using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
void OnCollisionEnter(Collision other) 
{
    switch(other.gameObject.tag)
    {
        case "Friendly":
             Debug.Log("this thing is friendly");
             break;
        case "Finish":
            Debug.Log("You just finish the game");
            break;
        case "Fuel":
            Debug.Log("You just took the fuel");
            break;
        default:
             Debug.Log("YOU HAVE BEEN BOOMED MOTHERFUCKER.");
             break;
    }

}
}
