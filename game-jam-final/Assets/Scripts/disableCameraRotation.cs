using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableCameraRotation : MonoBehaviour
{
    public Camera camera;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = rotation;
    }
}
