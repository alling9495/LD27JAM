using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class messageIndicatorHandler : MonoBehaviour {
    public int messageColorCount;
    public List<messageIndicator> indicators = new List<messageIndicator>(3);
    public bool active;
	// Use this for initialization
	void Start () {
	
	}

    public void setMessage(tubeMessage m)
    {
        
        messageColorCount = m.getColors().Count;
        for (int i = 0; i < messageColorCount; i++)
        {
            indicators[i].setMessage(m.getColors()[i]);
            if (m.getCurrStamps() > i)
            {
                indicators[i].stamped = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            for (int i = 0; i < messageColorCount; i++)
            {
                indicators[i].visible = true;
            }
        }
        else
        {
            foreach (messageIndicator ind in indicators)
            {
                ind.visible = false;
            }
        }

	}
    public void stamp()
    {
        for (int i = 0; i < messageColorCount; i++ )
        {

            if (indicators[i].stamped == false)
            {
                indicators[i].stamped = true;
                break;
            }
        }
    }
}
