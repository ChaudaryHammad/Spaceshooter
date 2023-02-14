using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSCROOL : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 4f;
    Vector3 StartPosition;
    void Start()
    {
        StartPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
        if(transform.position.z < -30.145f)
        {
            transform.position = StartPosition;
        }
        
    }
}
