using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(!GetComponent<PhotonView>().isMine)
			gameObject.GetComponent<AudioListener> ().enabled = false;

		if (!PhotonNetwork.isMasterClient) {
			//GetComponent<AudioListener>().enabled = true;
			GetComponent<PhotonView> ().TransferOwnership (PhotonNetwork.masterClient);

			Debug.Log("AUDIO ON");
		}

		//Debug.Log("AUDIO OFF");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
