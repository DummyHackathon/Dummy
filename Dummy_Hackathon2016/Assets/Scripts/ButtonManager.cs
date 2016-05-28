using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    Image img;
    float speed;

	// Use this for initialization
	void Start () {
        img = GameObject.Find("PlayImage").GetComponent<Image>();
        speed = 50.0f;
	}
	
	// Update is called once per frame
	void Update () {
        img.transform.Rotate(0.0f, 0.0f, speed * Time.fixedDeltaTime);
	}

    public void PlayClick()
    {
        SceneManager.LoadScene("Scene1");
    }
}
