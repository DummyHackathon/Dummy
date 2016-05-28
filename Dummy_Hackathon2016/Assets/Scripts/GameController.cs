using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public static GameController Instance { get; set; }

    public int numberOfTouch = 0; //Số lượng touch yêu cầu.
    public float timeToTouch = 0.0f; //Thời gian tối đa để touch

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool CheckTouch(int touch)
    {
        if (touch == numberOfTouch)
        {
            Debug.Log("Touch true");
            return true;
        }
        Debug.Log("Touch false");
        return false;
    }

    public bool CheckTime()
    {
        if (timeToTouch == 0)
        {
            Debug.Log("True");
            return true;
        }
        Debug.Log("False");
        return false;
    }
}
