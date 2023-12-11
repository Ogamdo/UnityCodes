using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Transform player;
    Vector3 offset;
    void Start()
    {
        offset = player.position - transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.position - offset;
        transform.LookAt(player);
    }

}
