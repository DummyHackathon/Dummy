using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController Instance { get; set; }

    public int numberOfTouch = 0; //Số lượng touch yêu cầu.
    public float timeToTouch = 0.0f; //Thời gian tối đa để touch
    float time;

    Image redBar;
    Image greenBar;

	// Use this for initialization
	void Start () {
        redBar = GameObject.Find("RedBar").GetComponent<Image>();
        greenBar = GameObject.Find("GreenBar").GetComponent<Image>();
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeToTouch > 0)
        {
            if ((time += Time.fixedDeltaTime) >= 1)
            {
                timeToTouch--;
                time = 0;
            }
        }
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

    public void UpdateGreenBar(float unit, bool plus)
    {
        if (plus)
        {
            greenBar.fillAmount += unit;
            redBar.fillAmount -= unit;
        }
        else
        {
            greenBar.fillAmount -= unit;
            redBar.fillAmount += unit;
        }
    }
}
