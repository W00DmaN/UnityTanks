using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
/*	public float speedBullet = 20.0F;
	public float interalShots = 1.0F;
	public Transform bullet;
	private float lastShotTime ;

	// Use this for initialization
	void Start () {
		lastShotTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E)) {
			if (Time.time>(lastShotTime + interalShots)) {
				Debug.Log(Time.time);
				GameObject bull_clone = Instantiate(bullet,transform.position, transform.rotation) as GameObject; 
				bull_clone.rigidbody.AddForce(transform.up*speedBullet, ForceMode.Impulse);
				lastShotTime = Time.time;
				//AudioSource.PlayClipAtPoint(myClip, transform.position);
			}
		}
	}*/

	public float speedBullet = 20.0F;
	public float interalShots = 1.0F; 
	public Transform bullet; 
	private float lastShotTime ; 
	//public AudioClip myClip;
	
	// Use this for initialization
	void Start () {
		lastShotTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E)) {
			if (Time.time>(lastShotTime + interalShots)) {
				GameObject bull_clone = (GameObject)Instantiate(bullet, transform.position, transform.rotation); 
				Physics.IgnoreCollision(bull_clone.collider, collider); 
				bull_clone.rigidbody.AddForce(transform.up*speedBullet, ForceMode.Impulse); lastShotTime = Time.time;
				//AudioSource.PlayClipAtPoint(myClip, transform.position);
			}
		}
	}
}
