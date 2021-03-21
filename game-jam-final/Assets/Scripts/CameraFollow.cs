using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform playerTransform;
    private float num = 1.5f;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x + 6;
        transform.position = temp;

        Vector3 tempY = transform.position;
        tempY.y = playerTransform.position.y + num;
        transform.position = tempY;
    }
}
