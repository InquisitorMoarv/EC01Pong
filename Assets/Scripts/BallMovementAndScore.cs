using UnityEngine;
using System.Collections;

public class BallMovementAndScore : MonoBehaviour {

    Vector3 vel;
    public float speed = 10;


	void Start () {
        if (Random.value >= 0.5f) { GetComponent<Rigidbody>().AddForce(speed, 0, 0); } else { GetComponent<Rigidbody>().AddForce(-speed, 0, 0); }
	}
	
	
	void FixedUpdate () {

        //vel = GetComponent<Rigidbody>().velocity.normalized * speed;
        //GetComponent<Rigidbody>().velocity = Vector3.Lerp(GetComponent<Rigidbody>().velocity, vel, Time.deltaTime);

	}
}
