using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
  [SerializeField] private float damage = 1f;

  //Called only the one frame that two colliders/rigidbodies start being in contact with OnCollisionEnter
  private void OnCollisionEnter(Collision other)
  {
      //Get the GameObject that we collided with
      var collidedGameObject = other.gameObject;
      // Look for HealthContainer on the GameObject we collided with, using GetComponent.
      var healthContainerOnCollidedGameObject = collidedGameObject.GetComponent<HealthContainer>();

      if (healthContainerOnCollidedGameObject != null)
      {
          healthContainerOnCollidedGameObject.DealDamage(damage);
          //healthContainerOnCollidedGameObject.InstantKill();
      }
  }
 
  
  //Called every second when two colliders/rigidbodies are in contact with OnCollisionStay 
  // private void OnCollisionSTAY(Collision other)
  // {
  //     //Get the GameObject that we collided with
  //     var collidedGameObject = other.gameObject;
  //     
  //     // Look for HealthContainer on the GameObject we collided with, using GetComponent.
  //     var healthContainerOnCollidedGameObject = collidedGameObject.GetComponent<HealthContainer>();
  //
  //     if (healthContainerOnCollidedGameObject != null)
  //     {
  //         healthContainerOnCollidedGameObject.DealDamage(damage * Time.deltaTime); //Deal damage over time.
  //         //healthContainerOnCollidedGameObject.InstantKill();
  //     }
  // }
}
