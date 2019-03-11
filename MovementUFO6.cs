using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementUFO6 : MonoBehaviour
{

    Vector2 pointB = new Vector2(22f, 3f);
    Vector2 pointA = new Vector2(25f, 3f);
    void Update()
    {
        transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 3f));

        transform.Rotate(new Vector3(0, 0, 216) * Time.deltaTime);
    }

}