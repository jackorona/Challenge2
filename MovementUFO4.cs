using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO4 : MonoBehaviour
{

    Vector2 pointA = new Vector2(6.5f, 3f);
    Vector2 pointB = new Vector2(6.5f, 0f);
    void Update()
    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1.5f));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}