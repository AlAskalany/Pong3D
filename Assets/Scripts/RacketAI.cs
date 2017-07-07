using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketAI : MonoBehaviour
{
    public GameObject Ball;
    private float _ballDirection = 0;

    // Use this for initialization
    private void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Ball") != null)
        {
            GetBallDirection();
        }
    }

    private void FixedUpdate()
    {
        if (!Ball)
            return;

        if (Mathf.Abs(transform.position.x - Ball.transform.position.x) < 2)
            MoveTowardsBall();
    }

    private void GetBallDirection()
    {
        _ballDirection = transform.position.z - Ball.transform.position.z;
    }

    private void MoveTowardsBall()
    {
        var newPosition = new Vector3(transform.position.x,
                                          transform.position.y,
                                          Ball.transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, newPosition, 0.3f);
    }
}