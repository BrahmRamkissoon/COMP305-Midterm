using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreboardController : MonoBehaviour {
    //  PUBLIC iNSTANCE VARIABLES +++++++++++++++++
    public Text scoreLabel;
    public Text livesLabel;

    
    // PRIVATE INSTANCE VARIABLES
    private int _scoreValue = 0;
    private int _livesValue = 5;

	// Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
        _ScoreUpdate();
    }

    //  PRIVATE METHODS
    private void _ScoreUpdate ()
    {
        this.scoreLabel.text = "Score: " + this._scoreValue;
        this.livesLabel.text = "Lives: " + this._livesValue;
    }

    // Allow other gameObjects to update score value 
    public void AddScore ( int scoreUpdate )
    {
        this._scoreValue += scoreUpdate;
    }

    public void RemoveLife(int lifeUpdate)
    {
        this._livesValue -= lifeUpdate;
    }
}
