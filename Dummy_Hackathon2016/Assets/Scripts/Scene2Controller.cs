using UnityEngine;
using System.Collections;

public class Scene2Controller : SceneController {

	new void TouchOnButton()
    {
        base.TouchOnButton();
        if (isWin == true)
        {
            Debug.Log("Vô");
            StartCoroutine(LoadScene("Scene3"));
        }
    }
}
