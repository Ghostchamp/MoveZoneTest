using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrajectoryRenderer : MonoBehaviour
{
    private LineRenderer lineRendererComponent;

    private void Start()
    {
        lineRendererComponent = GetComponent<LineRenderer>();
    }

    public void ShowTrajectory(Vector3 origin, Vector3 speed)
    {
        Vector3[] points = new Vector3[10];
        lineRendererComponent.positionCount = points.Length;

        for (int i = 0; i < points.Length; i++)
        {

            float time = i * 0.1f;

            points[i] = origin + (speed * time) + (Physics.gravity * time * time / 2f);
            Debug.Log(Physics.gravity);
            
        }

        lineRendererComponent.SetPositions(points);
    }
}
