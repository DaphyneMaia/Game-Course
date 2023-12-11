using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTrap : MonoBehaviour
{
    public GameObject trapPrefab; //the prefab that will be created when Player walks into trigger collider
    public Transform trapSpawnPos; //the location we will create the trap prefab

    private void OnTriggerEnter(Collider other) //function to check if something enters a collider on this object (collider MUST be set to 'IsTrigger')
    {
        if(other.gameObject.tag=="Player") //check if the object has the tag of 'Player'
        {
            Debug.Log("Player in the TRAP ZONE"); //print a message to the console
            Instantiate(trapPrefab, trapSpawnPos); //create a copy of the prefab at the position of the trap spawn object
            Destroy(gameObject); //destroy this object (the trigger collider, not the new trap) so we do not keep adding the same trap in the same place
        }
    }
    
}
