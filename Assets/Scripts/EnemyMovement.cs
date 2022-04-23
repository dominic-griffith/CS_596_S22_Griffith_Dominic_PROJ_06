using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int radius = 10;
    public float speed = 5f;
    public float angle = 0;

    private void Update()
    {

        float x = radius * Mathf.Cos(angle);
        float y = radius * Mathf.Sin(angle);

        Vector3 direction = new Vector3(x, 0f, y);

        transform.Translate(direction * Time.deltaTime * speed);

        angle += 15 * Mathf.Deg2Rad * Time.deltaTime;
    }
}
