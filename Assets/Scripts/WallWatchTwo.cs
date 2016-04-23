using UnityEngine;
using System.Collections;

public class WallWatchTwo : MonoBehaviour
{
    public BallManager BallManager;


    void OnTriggerEnter(Collider other)
    {
        BallManager.OneScore();
        Destroy(other.gameObject);
    }
}
