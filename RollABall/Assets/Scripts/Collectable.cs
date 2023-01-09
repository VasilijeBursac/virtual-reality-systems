using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private Vector3 rotationVector = new Vector3(15, 30, 45);

    
    //[SerializeField] private AudioClip collectedSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCollectable();
    }

    private void RotateCollectable()
    {
        transform.Rotate(rotationVector * Time.deltaTime);
    }
}
