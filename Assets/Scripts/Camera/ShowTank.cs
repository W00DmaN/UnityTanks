using UnityEngine;
using System.Collections;

public class ShowTank : MonoBehaviour {

	public GameObject tank;
	public GameObject secandTank;
	public float positionCamera = 5.0f;

	// Use this for initialization
	void Start () {
		//this.transform.position.y = positionCamera;
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3 (tank.transform.position.x, positionCamera, tank.transform.position.z);
		//this.transform.position.x = tank.transform.position.x;
		//this.transform.position.z = tank.transform.position.z;

		Vector3 camPosition = secandTank.transform.position- tank.transform.position;
		transform.position = camPosition + new Vector3(0,camPosition.magnitude,0);
	}
}
