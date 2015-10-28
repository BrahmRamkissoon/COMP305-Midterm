using UnityEngine;
using System.Collections;

[System.Serializable]
public class Speed {
	public float minSpeed, maxSpeed;
}

[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}


public class EnemyController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Speed speed;
	public Boundary boundary;
    public int tankValue = 10;

	// PRIVATE INSTANCE VARIABLES
	private float _CurrentSpeed;
	private float _CurrentDrift;
    private ScoreboardController _scoreboardController; // reference to ScoreboardController
    

	// Use this for initialization
	void Start () {
		this._Reset ();

        // Get Reference to ScoreboardController
	    this._GetScoreboardController();

	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= this._CurrentSpeed;
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// Check bottom boundary
		if (currentPosition.y <= boundary.yMin) {
			this._Reset();
		    
            // Update player score with 10 points every time a tank resets
		    this._scoreboardController.AddScore(tankValue);
		}
	}

	// resets the gameObject
	private void _Reset() {
		this._CurrentSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		Vector2 resetPosition = new Vector2 (Random.Range(boundary.xMin, boundary.xMax), boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}

    private void _GetScoreboardController()
    {
        // Find reference of ScoreboardController and assign to _scoreboardController
        GameObject scoreboardControllerObject = GameObject.FindGameObjectWithTag("ScoreboardController");
        if ( scoreboardControllerObject != null )
        {
            this._scoreboardController = scoreboardControllerObject.GetComponent<ScoreboardController>();
        }
        if ( scoreboardControllerObject == null )
        {
            Debug.Log("Cannot find 'ScoreboardController' script");
        }
    }
}
