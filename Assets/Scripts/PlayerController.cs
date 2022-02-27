using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    Rigidbody rb;
    int counter;

    [SerializeField]
    int speed;
    [SerializeField]
    Text text;
    [SerializeField]
    Text win;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        counter = 0;
        UpdateScore();
        win.gameObject.SetActive(false);
    }

    private void FixedUpdate() {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other) {
        // Debug.Log("Collider -> " + other);
        Destroy(other.gameObject);
        counter++;
        UpdateScore();
        
        if (counter >= 12) {
            win.gameObject.SetActive(true);
        }
    }

    private void UpdateScore() {
        text.text = "Score: " + counter;
    }

}
