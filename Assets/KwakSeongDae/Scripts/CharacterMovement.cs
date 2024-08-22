using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody Player;
    // Start is called before the first frame update
    void OnEnable()
    {
        if(TryGetComponent<Rigidbody>(out Player) == false)
        {
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var z = Input.GetAxis("Horizontal");
        var x = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(-x, 0, z);
        Player.velocity = velocity*5f;
    }
}
