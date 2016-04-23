using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallManager : MonoBehaviour {
    public int maxScore = 10;
    public int playerOneScore = 0;
    public int playerTwoScore = 0;
    public GameObject ball;
    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public GameObject WinObj;
    public Text Win;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }



    // Use this for initialization
    void Start () {
        Instantiate(ball, transform.position,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void nextStep() {
        Destroy(playerTwoScoreText);
        Destroy(playerOneScoreText);
        WinObj.SetActive(true);
    }




    public void TwoScore() {
        playerTwoScore++;
        if (playerTwoScore == maxScore) {
            nextStep();
            Win.text = "Player Two Wins";
            SceneManager.LoadScene("win");
        }
        Instantiate(ball, transform.position, transform.rotation);
        playerTwoScoreText.text = playerTwoScore.ToString();
    }
    public void OneScore()
    {
        playerOneScore++;
        if (playerOneScore == maxScore)
        {
            nextStep();
            Win.text = "Player One Wins";
            SceneManager.LoadScene("win");
        }
        Instantiate(ball, transform.position, transform.rotation);
        playerOneScoreText.text = playerOneScore.ToString();
    }
}
