using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene1Controller : MonoBehaviour {

    int touch;
    GameController gameController;
    bool? isWin = null;

	// Use this for initialization
	void Start () {
        touch = 0;
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update () {
        if (isWin == true)
        {
            gameController.UpdateGreenBar(0.1f, true);
            StartCoroutine(LoadScene("Scene2"));
        }
        else if (isWin == false)
        {
            gameController.UpdateGreenBar(0.1f, false);
            StartCoroutine(LoadScene("Scene2"));
        }
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
                isWin = true;
            }
        }
        else
        {
            if (!gameController.CheckTouch(touch))
            {
                Debug.Log("Fail rồi");
                isWin = false;
            }
        }
        
    }

    IEnumerator LoadScene(string scene)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }


}
