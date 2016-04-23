using UnityEngine;
using System.Collections;

public class WallWatchOne : MonoBehaviour
{
    public BallManager BallManager;


    void OnTriggerEnter(Collider other)
    {
        BallManager.TwoScore();
        Destroy(other.gameObject);
    }
}
