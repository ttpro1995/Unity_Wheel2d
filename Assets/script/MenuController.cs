using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public InputField firstinputfield;
    private InputField[] inputfield_list;

    //list
    public InputField inputfieldObj;
    public GameObject listParent;

	// Use this for initialization
	void Start () {
        GameData.NumOfChoose = 1;
        inputfield_list = new InputField[8];
        inputfield_list[0] = firstinputfield;
        GameData.wheelcontent = new string[8]{
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"
        };
       }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadScene()
    {
        /*
        string text = inputfield.text;
        int numofchoose = int.Parse(text);
        GameData.NumOfChoose = numofchoose;
        Application.LoadLevel("MainScene");
         */

        for (int i = 0; i < GameData.NumOfChoose;i++ )
        {
            print(inputfield_list[i].text);
            GameData.wheelcontent[i] = inputfield_list[i].text;
        }
        Application.LoadLevel("MainScene");
        
    }

    public void addInputText()
    {
        
        if (GameData.NumOfChoose < 8)
        {
            print("num of chose " + GameData.NumOfChoose);
            inputfield_list[GameData.NumOfChoose] = (InputField) Instantiate(inputfieldObj);
            Transform t = inputfield_list[GameData.NumOfChoose].GetComponent<Transform>();
            t.SetParent(listParent.GetComponent<RectTransform>());  
            GameData.NumOfChoose++;
        }
    }
}
