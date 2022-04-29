using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
   
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x - offset.x, player.position.y - offset.y, player.position.z - offset.z);
        
    }

}