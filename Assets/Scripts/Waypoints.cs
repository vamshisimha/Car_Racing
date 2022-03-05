using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour

{

  

    public Transform[] waypts;

    public Transform currentWaypoint;
    public int index;
    public float speed;
    public float turnSpeed;

    private void Start()
    {
        currentWaypoint = waypts[0];
    }
    public float minDistance;
    public float thedistance;
    private void FixedUpdate()
    {
        float dstbwcarandpoint = Vector3.Distance(transform.position, currentWaypoint.position);
        thedistance = dstbwcarandpoint;
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, speed * Time.deltaTime);
        Quaternion direction = Quaternion.LookRotation(currentWaypoint.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = Quaternion.Lerp(transform.rotation, direction, Time.deltaTime * turnSpeed);
        //transform.rotation = Quaternion.Lerp(transform.rotation, currentWaypoint.rotation, turnSpeed * Time.deltaTime);
        // transform.rotation = Quaternion.Slerp(transform.rotation, currentWaypoint.rotation, turnSpeed * Time.deltaTime);
        // transform.LookAt(currentWaypoint);


        if (dstbwcarandpoint <= minDistance)
            calculateNextWaypoint();
    }
  
    public void calculateNextWaypoint()
    {

        if (thedistance <= minDistance)
        {
            index++;

        }
        if (index >= waypts.Length)
            index = 0;

        currentWaypoint = waypts[index];


    }
}
