using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Belarus");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Shoot();
        }
    }

    void Shoot()
    {
        
    }
}
