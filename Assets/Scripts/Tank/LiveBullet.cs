using UnityEngine;
using System.Collections;

public class LiveBullet : MonoBehaviour {
	public float timeLiveBullet = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeLiveBullet -= Time.deltaTime;
		if (timeLiveBullet <= 0.0f) {
			Destroy(this.gameObject);
		}
	
	}
}
