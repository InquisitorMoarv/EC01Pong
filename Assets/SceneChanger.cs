using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {


	void Update () {

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("mainGame");
            Destroy(this);
        }
    }

}

