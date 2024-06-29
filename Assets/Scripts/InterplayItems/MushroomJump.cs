using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomJump : InterplayItems
{
    [SerializeField] private float jumpForce;

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
    }
}
