using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO7 : MonoBehaviour
{

    Vector2 pointA = new Vector2(28f, 3f);
    Vector2 pointB = new Vector2(32f, 0f);
    void Update()
    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1.2f));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}