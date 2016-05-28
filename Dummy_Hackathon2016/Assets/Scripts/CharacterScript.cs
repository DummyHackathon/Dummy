using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

    Transform gameObj;
    int touch;

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
        Vector3 newPosition = new Vector3(gameObj.position.x - Time.fixedDeltaTime * touch, gameObj.position.y, gameObj.position.z);
        gameObj.position = newPosition;

        //Vector3 newScale = new Vector3(gameObj.localScale.x - Time.fixedDeltaTime, gameObj.localScale.y, gameObj.localScale.z);
        //gameObj.localScale = newScale;
    }
}
