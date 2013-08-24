using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class tubeManager : MonoBehaviour {
    public List<tubeMessage> allMessages = new List<tubeMessage>(); //allMessages tracks every message in the system, whether it's with a worker or not. 
    public List<deskTube> deskQueues = new List<deskTube>(9); //Deskqueues are in charge of exposing workers to messages
    public Queue<tubeMessage> exitQueue = new Queue<tubeMessage>(); //ExitQueue stores messages right before they are removed from the system.
	// Use this for initialization

	void Start () {
     
        tubeMessage t = new tubeMessage(); //Test code to add some messages, comment out in end.

        for (int i = 1; i < 10; i++)
        {
            addMessage(t);
            moveTube(5, i);
        }
	}

    // Update is called once per frame
    void Update()
    {
        foreach (tubeMessage t in allMessages)
        {
            t.UpdateTime(Time.deltaTime); //Update the 10 second timer on every message
        }
        while (exitQueue.Count > 0)
        {
            //ExitQueue check routine for points happens here.

            allMessages.Remove(exitQueue.Dequeue());
        }
	}
    void addMessage(tubeMessage t)
    {
        allMessages.Add(t); //Add a messageTube to the main list.
        deskQueues[4].Enqueue(t); //Send the tube to desk 5, center routing desk.
    }
    public void moveTube(int from, int to)
    {
        if (from == 10) //tube 10 is the exit tube
        {
            Debug.Log("Can't start with exit queue, shouldn't be reached.");
        }
        if (from == to) //check the doubletap.
        {
            Debug.Log("Doubled up move, check which message it is..");
        }
        
        else if (deskQueues[from - 1].Count() > 0) //Do a quick check to make sure the queue isn't empty.
        {

            tubeMessage t = deskQueues[from - 1].Dequeue(); //Get the message, remove it from the deskqueue

            t.deskNum = to; //set the new desknumber
            if (to == 10) //Check to see if it's exiting the system.
            {
                exitQueue.Enqueue(t); //Add it to the exit pipe.
            }
            else
            {
                deskQueues[to - 1].Enqueue(t); //Enqueue it in the new desk.
            }
           Debug.Log("Message moved from " + from + " to " + to);
        }
        else
        {
            Debug.Log("No message in desk" + from); //If no message was there, notify.
        }
    }


   

}
