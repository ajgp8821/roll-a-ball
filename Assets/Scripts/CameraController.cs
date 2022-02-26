using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    GameObject player;

    private Vector3 relativePosition;

    private void Start() {
        relativePosition = transform.position - player.transform.position;
    }

    private void LateUpdate() {
        transform.position = player.transform.position + relativePosition;
    }
}
