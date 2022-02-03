using System;
using UnityEngine;

public class MoveTowardsPlayerAI : MonoBehaviour
{
  [SerializeField] private CommandController commandContainer;
  [SerializeField] private Transform playerTransform;

  private void Start()
  {
    // playerTransform = ((PlayerIdentifier) FindObjectOfType((typeof(PlayerIdentifier)))).transform; // Looks for a gameobject with componen PlayerIdentifier
    playerTransform = FindObjectOfType<PlayerIdentifier>().transform; //Looks for a gameobject with the component PlayerIdentfier but with cleaner code.
  }

  private void Update()
  {
    //to get a direction vector to a target: {Target:_Position} - {Origin_Position}
    var directionToPlayer = playerTransform.position - transform.position;
    
    directionToPlayer.Normalize();
    
    //Get the horizontal part of our direction. 
    var horizontalDirection = directionToPlayer.x;
    //Pass along direction to command container
    commandContainer.walkCommand = horizontalDirection;
  }
}
