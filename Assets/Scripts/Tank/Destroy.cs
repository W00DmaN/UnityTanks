using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public ParticleSystem boom;

	private void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Contains ("Tank")) {
			Instantiate(boom,col.gameObject.transform.position,col.gameObject.transform.rotation);
			Destroy(this.gameObject);
			Destroy(col.gameObject);
		}
	}
}
