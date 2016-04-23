using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {


	void Update () {
        if (Input.GetKey("x")) {
            Application.Quit();
        }
            

    }
}
