using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class tubeManager : MonoBehaviour {
    public List<tubeMessage> allMessages = new List<tubeMessage>();
    public List<deskTube> deskQueues = new List<deskTube>(9);
    public Queue<tubeMessage> exitQueue;
	// Use this for initialization

	void Start () {
     
        tubeMessage t = new tubeMessage();

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
            t.UpdateTime(Time.deltaTime);
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
        deskQueues[4].Enqueue(t); //Send the tube to desk 5
    }
    public void moveTube(int from, int to)
    {
        if (from == to)
        {
            Debug.Log("Doubled up move, check which message it is..");
        }
        else if (deskQueues[from - 1].Count() > 0) //Do a quick check to make sure the queue isn't empty.
        {
            tubeMessage t = deskQueues[from - 1].Dequeue();

            t.deskNum = to;
            deskQueues[to - 1].Enqueue(t);
            Debug.Log("Message moved from " + from + " to " + to);
        }
        else
        {
            Debug.Log("No message in desk" + from);
        }
    }


   

}
