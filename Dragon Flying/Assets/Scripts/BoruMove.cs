using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruMove : MonoBehaviour
{

    public float speed;

    void Start()
    {
        Destroy(gameObject,10);    
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
