using UnityEngine;
using System.Collections;

public class Scene3Controller : SceneController {

    Transform gameObj;

    public float backgroundWidth;
    public float backgroundCount;

    new void Start()
    {
        base.Start();
        gameObj = GameObject.Find("Background").GetComponent<Transform>();
    }

    new void TouchOnButton()
    {
        base.TouchOnButton();
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
    