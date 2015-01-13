using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 20.0F;

	private float horiz;
	private float vertic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		horiz = Input.GetAxis("Horizontal");
		transform.Rotate (new Vector3(0.0f, horiz, 0.0f));
		vertic = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (new Vector3 (-(vertic),0.0f, 0.0f));
	}
}
