using UnityEngine;
using System.Collections;

public class messageIndicator : MonoBehaviour {

    bool visible = true;
    public bool stamped;
    public readonly Vector2 texScale = new Vector2(0.125f, 0.25f);
    private Vector2 offset;
    private Vector2 stampedOffset = new Vector2(0.25f, 0);
    public tubeMessage.messageColor stampColor;
	// Use this for initialization
	void Start () {
	    renderer.material.mainTextureScale = texScale;
        setMessage(stampColor);
	}
	
	// Update is called once per frame
	void Update () {
        
        if (visible)
        {
            if (stamped)
            {
                renderer.material.mainTextureOffset = offset + stampedOffset;
            }
            else
            {

                renderer.material.mainTextureOffset = offset;
            }
        }
              setMessage(stampColor);
	}
    public void setMessage(tubeMessage.messageColor col)
    {
        stampColor = col;
        switch (stampColor)
        {
            case tubeMessage.messageColor.red:
                {
                    offset = new Vector2(0.5f, -.25f);
                    break;
                }
            case tubeMessage.messageColor.orange:
                {
                    offset = new Vector2(0.625f, -.25f);
                    break;
                }
            case tubeMessage.messageColor.blue:
                {
                    offset = new Vector2(0.5f, -.5f);
                    break;
                }
            case tubeMessage.messageColor.green:
                {
                    offset = new Vector2(0.625f, -.5f);
                    break;
                }
            case tubeMessage.messageColor.rg:
                {
                    offset = new Vector2(0.5f,-.75f);
                    break;
                }
            case tubeMessage.messageColor.go:
                {
                    offset = new Vector2(0.625f, -.5f);
                    break;
                }
            case tubeMessage.messageColor.br:
                {
                    offset = new Vector2(0.5f, -1f);
                    break;
                }
            case tubeMessage.messageColor.ob:
                {
                    offset = new Vector2(0.625f, -1f);
                    break;
                }
            default:
                {
                    offset = new Vector2(0.5f, -.25f);
                    break;
                }

        }

    }


}
