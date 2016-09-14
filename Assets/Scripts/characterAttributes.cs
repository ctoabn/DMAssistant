using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class characterAttributes : MonoBehaviour {

    public string Name;
    public int Strength = 0;
    public int Agility = 0;
    public int Endurance = 0;
    public int Presence = 0;
    public int Reaction = 0;
    public int Logic = 0;
    public int Wisdom = 0;
    public int Willpower = 0;

    // Use this for initialization
    void Start () {

        
	
	}
	
	// Update is called once per frame
	void Update () {
	    /*for(int i = 0; i < transform.childCount; i++) {
            transform.GetChild(i).GetComponent<Text>().text = 
        }*/
	}

    public string GetAttribute(string s) {
        switch (s)
        {
            case "Name":
                return Name;
            case "Agility":
                return Agility.ToString();
            case "Reaction":
                return Reaction.ToString();
            default:
                return "NULL";
        }
            
            
    }
}
