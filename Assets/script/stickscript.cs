using UnityEngine;
using System.Collections;
using UnityEngine.UI;//Text

public class stickscript : MonoBehaviour {

	public Text result;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Hit item "+ other.name);
		result.text = other.name;
	}

}
