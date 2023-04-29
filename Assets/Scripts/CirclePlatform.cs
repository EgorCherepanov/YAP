using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePlatform : MonoBehaviour
{
    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 2f, angularSpeed = 2f;

    float positionX, positionY, angel = 0f;

    // Update is called once per frame
    void Update()
    {
        positionX = center.position.x + Mathf.Cos(angel) * radius;
        positionY = center.position.y + Mathf.Sin(angel) * radius;
        transform.position = new Vector2(positionX, positionY);
        angel = angel + Time.deltaTime * angularSpeed;
        if (angel >= 360f)
        {
            angel = 0f;
        }
    }
}
