using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scene3Controller : SceneController {

    Transform gameObj;
    public Image ImageRoad;

    public float backgroundWidth;
    public float backgroundCount;
    public float speed = 0.1f;
    Animator anim;
    public GameObject character;
    public GameObject clockImage;

    new void Start()
    {
        base.Start();
        //anim = GameObject.Find("Character").GetComponent<Animator>();
        gameObj = GameObject.Find("Background").GetComponent<Transform>();
        
    }

    new void Update()
    {
        clockImage.GetComponent<Image>().fillAmount -= Time.fixedDeltaTime / (float)6;
        gameObj.transform.Translate(Vector3.left * Time.fixedDeltaTime * speed);
        Vector3 pos = gameObj.position;
        if (pos.x < -backgroundWidth)
        {
            pos.x += backgroundWidth * backgroundCount;
            gameObj.position = pos;
        }
        if (ImageRoad.fillAmount >= 1 && clockImage.GetComponent<Image>().fillAmount >= 0)
        {
            StartCoroutine(LoadScene("Scene4"));
        }
    }

    new void TouchOnButton()
    {
        base.TouchOnButton();
        ImageRoad.fillAmount += (float)1 / (float)25;
        speed += 0.5f;
    }
}
    