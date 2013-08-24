using UnityEngine;
using System.Collections;

public class workerHandler : MonoBehaviour {

    enum state {answering, thinking, result ,waiting};
    public tubeMessage.messageColor answerColor;
    public tubeMessage currMessage;
    public SpeechOverlaySelector speechBubble;
 
    float timer = 0;
    public float ExclamationDelay = 1.0f;
    public float dotsDelay = 1.0f;
    public float resultDelay = 2.0f;

    private state currState = state.waiting;
   
    // Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
	    if(currState == state.answering)
        {
            if (timer < ExclamationDelay)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
                currState = state.thinking;
                speechBubble.setDots();
            }
        }
        else if(currState == state.thinking)
        {
            if (timer < dotsDelay)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
                currState = state.answering;
                checkMessage(currMessage);
            }
        }

	}

    public void getMessage(tubeMessage m)
    {
        currMessage = m;
        speechBubble.setExclamation();
        currState = state.answering;
    }
    void checkMessage(tubeMessage m)
    {
        if (m.currUnstampedColor() == answerColor)
        {
            m.stamp();
            speechBubble.setCheck();
        }
        else
        {
            speechBubble.setCross();
        }
        currState = state.result;

    }

    public bool processingMessage()
    {
        return currState != state.waiting;
    }

}
