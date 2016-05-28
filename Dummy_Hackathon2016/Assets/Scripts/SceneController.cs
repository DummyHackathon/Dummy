using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {

    public int touch;
    public GameController gameController;
    public bool? isWin = null;
    public Image Result;
    Text txtResult;

    // Use this for initialization
    public void Start()
    {
        touch = 0;
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
        Result = GameObject.FindWithTag("Image").GetComponent<Image>();
        txtResult = GameObject.FindWithTag("Image").GetComponentInChildren<Text>();
        Result.enabled = false;
        txtResult.enabled = false;
    }

    // Update is called once per frame
    public void Update () {
	
	}

    public void TouchOnButton()
    {
        touch++;
        if (!gameController.CheckTime() && gameController.CheckTouch(touch))
        {
            isWin = true;
            Result.enabled = true;
            txtResult.enabled = true;
        }
        else
        {
            isWin = false;
        }
        Debug.Log("isWin" + isWin);
    }

    public IEnumerator LoadScene(string scene)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(scene);
    }
}
