using UnityEngine;
using System.Collections;

public class BoomDestroy : MonoBehaviour {

	private ParticleSystem boom;

	// Use this for initialization
	void Start () {
		boom = (ParticleSystem)GetComponent (typeof(ParticleSystem));
	
	}
	
	// Update is called once per frame
	void Update () {
		if (boom) {
			if(!boom.IsAlive()){
				Destroy(gameObject);
			}
		}
	
	}
}
