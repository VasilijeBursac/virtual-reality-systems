using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Vector3 dropPosition = new Vector3(2f, 2f, 2f);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");

        // Set new ball position when the Space key is pressed - Gravity will pull the ball down
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = dropPosition;

        Debug.Log(transform.position);
    }
}
