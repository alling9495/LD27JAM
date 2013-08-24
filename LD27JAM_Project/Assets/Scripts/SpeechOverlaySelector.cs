using UnityEngine;
using System.Collections;

public class SpeechOverlaySelector : MonoBehaviour {

	// Use this for initialization
   
    Vector2 currOffset = Vector2.zero;
    Vector2 nextOffset = Vector2.zero;
    public readonly Vector2 texScale = new Vector2(0.25f, 0.5f);
    public bool switching;
    
    void Start () {
        renderer.material.mainTextureScale = texScale;
	}
	
	// Update is called once per frame
	void Update () {
        //Debug key codes to try switching
        if (Input.GetKeyDown(KeyCode.F1))
        {
            setExclamation();
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            setDots();
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            setCheck();
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            setCross();
        }
        
	    if(switching)
        {
            transform.localScale = new Vector3(transform.localScale.x - .1f, transform.localScale.y, transform.localScale.z);
            if(transform.localScale.x <= 0)
            {
                transform.localScale = new Vector3(0, transform.localScale.y, transform.localScale.z);
                switching = false;
                currOffset = nextOffset;
                renderer.material.SetTextureOffset("_MainTex",nextOffset);
            }
        }
        else if(transform.localScale.x < 0.5f)
        {
            transform.localScale = new Vector3(transform.localScale.x+.1f,transform.localScale.y,transform.localScale.z);
        }
	}

    public void setExclamation()
    {
         nextOffset = new Vector2(0, -0.5f);
        if (!currOffset.Equals(nextOffset))
        {
           
            switching = true;
        }
    }
    public void setDots()
    {
        nextOffset = new Vector2(0.25f, -0.5f);
        if (!currOffset.Equals(nextOffset))
        {
            switching = true;
        }
    }
    public void setCheck()
    {
        nextOffset = new Vector2(0, 0);
        if (!currOffset.Equals(nextOffset))
        {
            switching = true;
        }

    }
    public void setCross()
    {
        nextOffset = new Vector2(0.25f, 0);
        if (!currOffset.Equals(nextOffset))
        {
            switching = true;
        }
    }
           

    

    


}
