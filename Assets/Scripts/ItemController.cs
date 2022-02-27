using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {

    Vector3 rotation = new Vector3(15, 30, 45);

    private void Update() {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
