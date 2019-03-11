using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO2 : MonoBehaviour
{

    Vector2 pointA = new Vector2(1f, 2f);
    Vector2 pointB = new Vector2(-3f, 2f);
    void Update()

    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}