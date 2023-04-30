using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCube : MonoBehaviour
{
    private Rigidbody cube;
    public static Vector3 diceVelocity;

    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Roll();
    }

    void Roll()
    {
        diceVelocity = cube.velocity;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);
            transform.rotation = Quaternion.identity;
            cube.AddForce(transform.up * 500);
            cube.AddTorque(dirX, dirY, dirZ);
        }
    }
}
