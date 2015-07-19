using UnityEngine;
using System.Collections;

public class SpinIcon : MonoBehaviour {
	public RectTransform spinner;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spinner.transform.Rotate (Vector3.forward * -1);
	}
}
