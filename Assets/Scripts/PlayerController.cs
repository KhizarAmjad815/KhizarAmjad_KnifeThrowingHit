using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject knifePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !GameManager.isGameOver)
        {
            Instantiate(knifePrefab, new Vector3(0f, -1.83f, 0f), knifePrefab.transform.rotation);
        }
    }
}
