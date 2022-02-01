using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
   [SerializeField] private float maxHealth = 3f;

   //Dont set a value because we want to add it ourself
   private float currentHealth;
   
   private void Start()
   {
      //We can now change our current health to what we change it into in  the inspector.
      currentHealth = maxHealth;
   }

   // private void OnEnable()
   // {
   //    //this method runs when a GameObject is activated (enabled)
   // }
   // private void OnDisable()
   // {
   //    //this method runs when a GameObject is activated (enabled)
   // }

   public void DealDamage(float damage) //We use a float to be able to use the damage in different ways
   {
      currentHealth -= damage;
      CheckHealth();
   }

   private void CheckHealth()
   {
      if (currentHealth <= 0) //if we use == we could run around with zero health and still be alive
      {
         Die();
      }
   }

   private void Die()
   {
      Destroy(gameObject);
      //Instantiate()
         //gameObject.setActive(false); //This disables the gameObject
   }

   private void InstantKill()
   {
      Die(); //You cold also make die() public and call that directly. 
   }
}


