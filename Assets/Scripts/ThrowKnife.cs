using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnife : MonoBehaviour
{
    private Rigidbody knifeRB;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        knifeRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        knifeRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            GameManager.isGameOver = true;
            Debug.Log("Game Over");
        }

        if (collision.gameObject.CompareTag("Log"))
        {
            gameObject.transform.SetParent(collision.transform, true);
            //this.transform.parent = collision.transform;
            knifeRB.constraints = RigidbodyConstraints.FreezePosition
                | RigidbodyConstraints.FreezeRotation;
            GameManager.score++;
        }

        GameManager.gameManager.UpdateScore();
    }
}
