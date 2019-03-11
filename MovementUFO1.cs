using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO1 : MonoBehaviour
{

    Vector2 pointA = new Vector2(-2f, -2.5f);
    Vector2 pointB = new Vector2(3f, -2.5f);
    void Update()

    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}