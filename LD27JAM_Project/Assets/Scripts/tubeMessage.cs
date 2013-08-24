using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class tubeMessage{

    public enum messageColor { red, green, orange, blue, rg, go, ob, br } // Colors avalible to the tubes. 
    private List<messageColor> colorList = new List<messageColor>(3);
    public int deskNum = 5;
    private int stamps = 0;
    private float time = 10;
    // Use this for initialization

    public tubeMessage()
    {
    }
    public tubeMessage(List<messageColor> colors)
    {
        setColors(colors);
    }

	void Start () {
	    
	}

    public void setColors(List<messageColor> colors)
    {
        foreach (messageColor c in colors)
        {
            colorList.Add(c); //Copy a list into the messages normal list.
        }
    }

    public messageColor currUnstampedColor() 
    {
        if (stamps >= colorList.Count-1)
        {
            return colorList[colorList.Count - 1];
        }
        else
        {
            return colorList[stamps];
        }
    }
    public bool completed()
    {
        return stamps == colorList.Count;
    }

    public void stamp()
    {
        stamps++;
    }

    public int getCurrStamps()
    {
        return stamps;
    }

	public void UpdateTime (float deltaTime) {
        if (time > 0)
        {
            time = Mathf.Clamp(time, 0, time - deltaTime);
        }
     }
}
