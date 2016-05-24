using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    string HORIZONTAL = "Horizontal";
    string VERTICAL = "Vertical";

    private Rigidbody rb;

    public float speed;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis(HORIZONTAL);
        float moveVertical = Input.GetAxis(VERTICAL);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count += 1; 
    }
}
