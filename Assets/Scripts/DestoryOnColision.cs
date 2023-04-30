using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
