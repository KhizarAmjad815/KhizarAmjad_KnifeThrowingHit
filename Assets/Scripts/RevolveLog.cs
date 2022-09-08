using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveLog : MonoBehaviour
{
    public float rotationSpeed = 80.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.isGameOver)
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
