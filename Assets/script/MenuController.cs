using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public InputField inputfield;

	// Use this for initialization
	void Start () {
        
       }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadScene()
    {
        string text = inputfield.text;
        int numofchoose = int.Parse(text);
        GameData.NumOfChoose = numofchoose;
        Application.LoadLevel("MainScene");
    }
}
