using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setText : MonoBehaviour {
    private Text textbox;
    // Use this for initialization
    void Start () {
        textbox = this.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        textbox.text = name + ": " + GetComponentInParent<characterAttributes>().GetAttribute(name);
        
	}
}
