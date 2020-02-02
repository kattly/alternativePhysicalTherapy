using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSync : MonoBehaviour
{
    public Transform world;
    public Transform player;
    private Vector3 posOffset;
    private Quaternion rotOffset;

    // Start is called before the first frame update
    void Start()
    {
        posOffset = world.position - transform.position;
        rotOffset = world.rotation * Quaternion.Inverse(transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void syncTransform()
    {
        Vector3 newPos = transform.position;
        Quaternion newRot = transform.rotation;

        world.position = newPos + posOffset;
        world.rotation = newRot * rotOffset;

        //transform.position = newPos;
        //transform.rotation = newRot;
    }

    public void moveToPoint(Transform point)
    {
        player.position = point.position;
    }
}
