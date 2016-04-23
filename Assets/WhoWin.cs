using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WhoWin : MonoBehaviour {
//public ScriptableObject Trans = GameObject.Find("Hermes").GetComponent("script");
    public bool PlayerOneWin;
    public Text wintext;
	// Use this for initialization
	
        void Start () {
        
        //PlayerOneWin = Trans.playerOneWon;
       wintext.text = "TESTFROMSCRIPT";
    }
	

}
