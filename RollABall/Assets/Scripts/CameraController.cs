using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
