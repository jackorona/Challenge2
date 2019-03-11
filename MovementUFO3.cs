using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO3 : MonoBehaviour
{

    Vector2 pointA = new Vector2(3, -2.5f);
    Vector2 pointB = new Vector2(6, -2.5f);
    void Update()
    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 2));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}