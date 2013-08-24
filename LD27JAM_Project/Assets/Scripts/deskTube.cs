using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class deskTube : MonoBehaviour {

    public Queue<tubeMessage> messages = new Queue<tubeMessage>();
    public tubeMessage currentMessage;
    public float shipDelay; //Delay for shipping animation
    public float recieveDelay; //Delay for recieving animation.

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Enqueue(tubeMessage t)
    {
        messages.Enqueue(t); //Wrappers for functions
    }
    public tubeMessage Dequeue()
    {
        return messages.Dequeue(); //EZ
    }
    public int Count()
    {
        return messages.Count; //Another wrapper
    }
   

}
