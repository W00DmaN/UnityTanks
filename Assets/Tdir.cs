using UnityEngine;
using System.Collections;

public class Tdir : MonoBehaviour {

	// Use this for initialization
	Transform tr;
	
	void Start () {  tr = transform;  }
	
	void Update ()
	{
		Debug.Log("Local=" + Vector3.right + " | Global=" + tr.TransformDirection(Vector3.right));
	}
}
