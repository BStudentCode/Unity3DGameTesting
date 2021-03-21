using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    //transform refers to transform of object script is sitting on
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
