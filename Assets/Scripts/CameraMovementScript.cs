using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{

    // make the camera move with the player
    // serialize field allows you attatch the player to the camera object in the game and track the players position
    [SerializeField] private Transform playersPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // make camera move like the player moves
        transform.position = new Vector3(playersPosition.position.x, transform.position.y, transform.position.z);

    }

}
