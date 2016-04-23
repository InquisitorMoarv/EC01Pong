using UnityEngine;
using System.Collections;

public class lookatcam : MonoBehaviour {
    public Transform target;
	void Update () {
        transform.LookAt(target);
    }
}
