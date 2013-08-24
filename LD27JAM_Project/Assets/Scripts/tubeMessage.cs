using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class tubeMessage : MonoBehaviour {

    public enum messageColor { red, green, orange, blue, rg, go, ob, br } // Colors avalible to the tubes. 
    private List<messageColor> colorList = new List<messageColor>();
    public int deskNum;
    private int stamps = 0;
    // Use this for initialization

	void Start () {
	    
	}

    public void setColors(List<messageColor> colors)
    {
        foreach (messageColor c in colors)
        {
            colorList.Add(c);
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

	// Update is called once per frame
	void Update () {
	
	}
}
