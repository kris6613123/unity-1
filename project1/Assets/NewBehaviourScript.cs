using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(0, 300f, 0);
        }
            float speed = 5f;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow)) { 
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) { 
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
