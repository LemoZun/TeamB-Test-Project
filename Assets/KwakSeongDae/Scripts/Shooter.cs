using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody bullet;
    public float power;
    public Vector3 shootPos;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        { 
            var transform = GetComponent<Transform>();
            Instantiate(bullet,transform.position+shootPos,transform.rotation)?.AddForce(Vector3.left*power);   
        }
    }
}
