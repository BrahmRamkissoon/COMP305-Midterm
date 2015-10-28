using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    //  PRIVATE INSTANCE VARIABLES
    private ScoreboardController _scoreboardController;
    private int _deathValue = 1;


	// Use this for initialization
	void Start ()
	{
	    _GetScoreboardController();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if (otherGameObject.tag == "Enemy")
        {
            _scoreboardController.RemoveLife( _deathValue );
        }
    }

    private void _GetScoreboardController ()
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
