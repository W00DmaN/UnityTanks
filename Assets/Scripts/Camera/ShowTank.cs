using UnityEngine;
using System.Collections;

public class ShowTank : MonoBehaviour {

	public Transform tank;
	public float positionCamera = 5.0f;

	// Use this for initialization
	void Start () {
		//this.transform.position.y = positionCamera;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (tank.transform.position.x, positionCamera, tank.transform.position.z);
	}
}
