using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    Image img;
    float speed;
    int firstTimeRun = 0;
    GameController gameController;

	// Use this for initialization
	void Start () {
        img = GameObject.Find("PlayImage").GetComponent<Image>();
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
        speed = 50.0f;
	}
	
	// Update is called once per frame
	void Update () {
       img.transform.Rotate(0.0f, 0.0f, speed * Time.fixedDeltaTime);
	}

    public void PlayClick()
    {
        if (PlayerPrefs.HasKey("firstRun"))
        {
            firstTimeRun = PlayerPrefs.GetInt("firstRun");
            if (firstTimeRun == 0)
            {
                SceneManager.LoadScene("Tutorial");
            }
        }
        else
        {
            SceneManager.LoadScene("Scene1");
        }
    }
}
