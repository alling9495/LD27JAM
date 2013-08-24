using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class deskTube : MonoBehaviour {

    public Queue<tubeMessage> messages = new Queue<tubeMessage>();
    public tubeMessage currentMessage;
    public float shipDelay;
    public float recieveDelay;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Enqueue(tubeMessage t)
    {
        messages.Enqueue(t);
    }
    public tubeMessage Dequeue()
    {
        return messages.Dequeue();
    }
    public int Count()
    {
        return messages.Count;
    }
   

}
