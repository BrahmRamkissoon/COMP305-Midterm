using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreboardController : MonoBehaviour {
    //  PUBLIC iNSTANCE VARIABLES +++++++++++++++++
    public Text scoreLabel;
    public Text livesLabel;


    private int _score = 0;
    private int _lives = -5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //  PRIVATE METHODS
    private void _ScoreUpdate ()
    {
        this.scoreLabel.text = "Score: " + this._score;
        this.livesLabel.text = "Lives: " + this._lives;
    }
}
