using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	private void OnCollisionEnter(Collision col){
		if (col.gameObject.name.Contains ("Tank")) {
				Destroy(this.gameObject);
				Destroy(col.gameObject);
		}
	}
}
