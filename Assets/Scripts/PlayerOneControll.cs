using UnityEngine;
using System.Collections;

public class PlayerOneControll : MonoBehaviour {

    Vector3 playerPos;
    public float speed = 10;
    public GameObject player;
    string oneAxi = "Vertical2";
    string twoAxi = "Vertical";
    string curAxi;
    float onePos = 11f;
    float twoPos = -9f;
    float curPos;
 

    void Start()
    {
        if (player.name == "PlayerOne")
        {
            curPos = onePos;
            curAxi = oneAxi;
            Vector3 playerPos = new Vector3(11, 1.5f, 1);
        }
        else {
            curPos = twoPos;
            curAxi = twoAxi;
            Vector3 playerPos = new Vector3(-9, 1.5f, 1);
        }
        

    }

    void Update()
    {
        float xPos = transform.position.z + (Input.GetAxis(curAxi) * speed);
        playerPos = new Vector3(curPos,1.5f,Mathf.Clamp(xPos, -3, 5));
        transform.position = playerPos;

    }
}
