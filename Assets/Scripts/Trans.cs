using UnityEngine;
using System.Collections;

public class Trans : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
