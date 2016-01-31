using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	[SerializeField]
	float forceValue = 4.5f;
	Rigidbody2D myBody;
	// Use this for initialization
	void Start () {
		StartCoroutine(Reset());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Reset() 
	{
		myBody = GetComponent<Rigidbody2D>();
		yield return WaitForSeconds (3);
		// reset the ball position and restart the ball movement
		myBody.velocity = Vector2.zero;
		transform.position = new Vector2(0,0);
		myBody.AddForce (new Vector2 (forceValue * 50, 50));
		forceValue = forceValue * -1;
	}

	public void Stop()
	{
		// this method stops the ball
		myBody.velocity = Vector2.zero;
	}
}
