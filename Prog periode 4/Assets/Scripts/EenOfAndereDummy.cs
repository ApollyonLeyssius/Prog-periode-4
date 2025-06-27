using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EenOfAndereDummy : MonoBehaviour
{
    private Vector3 startPos;
    private float moveRange = 5f;
    private float speed = 2f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.Sin(Time.time * speed) * moveRange;
        transform.position = new Vector3(startPos.x + x, startPos.y, startPos.z);
    }
}
