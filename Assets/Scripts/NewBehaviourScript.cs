using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void action()
    {
        Destroy(gameObject);
        text.GetComponent<Text>().text = "Мужик сделал корабль и улетел";
    }
}
