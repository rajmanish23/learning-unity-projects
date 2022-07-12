using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
    [SerializeField] private GameObject obj;
    
    private void Start() {
        obj.transform.Rotate(Vector3.forward);
    }

    private void Update() {
        obj.transform.Translate(Vector3.forward);
        obj.transform.Rotate(Vector3.right);
    }
}
