using UnityEngine;
using System.Collections;

public class deskInputManager : MonoBehaviour {
    public KeyCode desk1;
    public KeyCode desk2;
    public KeyCode desk3;
    public KeyCode desk4;
    public KeyCode desk5;
    public KeyCode desk6;
    public KeyCode desk7;
    public KeyCode desk8;
    public KeyCode desk9;
    public KeyCode exitPipe;
    public tubeManager manager;
    private int firstPress = -1;
    private int secondPress = -1;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
   
        if (firstPress == -1)
        {
            firstPress = getDeskKey();
        }
        else if (secondPress == -1)
        {
            secondPress = getDeskKey();
        }
        else
        {
            manager.moveTube(firstPress, secondPress);
            firstPress = -1;
            secondPress = -1;
        }
	}
    int getDeskKey()
    {
        if(Input.GetKeyDown(desk1))
        {
            return 1;
        }
        if (Input.GetKeyDown(desk2))
        {
            return 2;
        }
        if (Input.GetKeyDown(desk3))
        {
            return 3;
        }
        if (Input.GetKeyDown(desk4))
        {
            return 4;
        }
        if (Input.GetKeyDown(desk5))
        {
            return 5;
        }
        if (Input.GetKeyDown(desk6))
        {
            return 6;
        }
        if (Input.GetKeyDown(desk7))
        {
            return 7;
        }
        if (Input.GetKeyDown(desk8))
        {
            return 8;
        }
        if (Input.GetKeyDown(desk9))
        {
            return 9;
        }
        if (Input.GetKeyDown(exitPipe))
        {
            return 10;
        }
        return -1;

    }

}
