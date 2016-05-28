using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    Transform gameObj;
    int touch;
    public float backgroundWidth;
    public float backgroundCount;

	// Use this for initialization
	void Start () {
        gameObj = GameObject.Find("Background").GetComponent<Transform>();
        touch = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CharacterTouch()
    {
        touch++;
        //Vector3 newPosition = new Vector3(gameObj.position.x - Time.fixedDeltaTime * touch, gameObj.position.y, gameObj.position.z);
        //gameObj.position = newPosition;
        gameObj.transform.Translate(Vector3.left * Time.fixedDeltaTime * touch);
        Vector3 pos = gameObj.position;
        if (pos.x < -backgroundWidth)
        {
            pos.x += backgroundWidth * backgroundCount;
            gameObj.position = pos;
        }
    }
}
