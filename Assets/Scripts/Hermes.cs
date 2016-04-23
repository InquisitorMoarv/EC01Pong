using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hermes : MonoBehaviour
{
    public Text Score;
    public Text Score2;
    public Text Win;
    public bool playerOneWon;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
