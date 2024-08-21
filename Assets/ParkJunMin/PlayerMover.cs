using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update
    public int movePower;
    public bool check;
    public string text;

    public Collider collider;
    public Rigidbody rigidbody;


    private void Start() // 시작할때 한번 호출되는 메서드
    {
        rigidbody.AddForce(Vector3.up * movePower, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * movePower, ForceMode.Force);
        }

    }

    public void Test()
    {

    }

}
