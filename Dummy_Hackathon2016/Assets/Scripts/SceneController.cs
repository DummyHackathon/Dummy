using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public int touch;
    public GameController gameController;
    public bool? isWin = null;

    // Use this for initialization
    public void Start()
    {
        touch = 0;
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    // Update is called once per frame
    public void Update () {
	
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

    public IEnumerator LoadScene(string scene)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }
}
