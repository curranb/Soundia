using UnityEngine;
using System.Collections;

public class MoveInCircle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float angle = 0;
	public float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	public float radius = 5;

	void Update()
	{
		float x;
		float y;
		angle += speed*Time.deltaTime; //if you want to switch direction, use -= instead of +=
		x = Mathf.Cos(angle)*radius;
		y = Mathf.Sin(angle)*radius;

		transform.position = new Vector3 (x, gameObject.transform.position.y, y);
	}
}
