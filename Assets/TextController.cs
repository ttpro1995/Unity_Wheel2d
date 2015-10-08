using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour {

    private string displayText;
    private TextMesh testMesh;

	// Use this for initialization
	void Start () {
        displayObjectName();
        
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void displayObjectName()
    {
        displayText = transform.parent.gameObject.name;//get display text
        testMesh = GetComponent<TextMesh>();//
        testMesh.text = displayText;
    }
}
