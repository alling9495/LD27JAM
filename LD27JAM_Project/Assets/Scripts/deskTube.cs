using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class deskTube : MonoBehaviour {

    public Queue<tubeMessage> messages = new Queue<tubeMessage>();
  
    public bool canSend;
    float timer = 0;
    public float shipDelay=0.1f; //Delay for shipping animation
    public float recieveDelay=0.2f; //Delay for recieving animation.
    public workerHandler worker;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (messages.Count > 0 && !worker.processingMessage())
        {
            worker.getMessage(messages.Peek());
        }
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
