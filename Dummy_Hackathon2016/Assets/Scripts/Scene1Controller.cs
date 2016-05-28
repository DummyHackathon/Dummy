using UnityEngine;
using System.Collections;

public class Scene1Controller : MonoBehaviour {

    int touch;
    GameController gameController;

	// Use this for initialization
	void Start () {
        touch = 0;
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update () {
	    
	}

    public void TouchOnButton()
    {
        touch++;
        Debug.Log(touch);
        if (!gameController.CheckTime())
        {
            if (gameController.CheckTouch(touch))
            {
                Debug.Log("Đã đủ");
            }
        }
    }
}
