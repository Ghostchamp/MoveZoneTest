using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    private Rigidbody Rigidbody;

    private void Start()
    {

    }

    public void ShootBull(float velocity)
    {
        Rigidbody.velocity = transform.forward * velocity;
    }    
}
