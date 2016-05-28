using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene1Controller : SceneController {

    public GameObject Character;
    public GameObject Sleeping;
    Animator anim;
    new void Start()
    {
        base.Start();
        anim = GameObject.Find("Character").GetComponent<Animator>();
        if (Character.activeSelf == true)
        {
            Character.SetActive(false);
        }
    }

    new void TouchOnButton()
    {
        base.TouchOnButton();
        if (isWin == true)
        {
            Sleeping.SetActive(false);
            Character.SetActive(true);
            anim.SetTrigger("Wakeup");
        }
    }

    public void BathroomClick()
    {
        gameController.UpdateGreenBar(0.02f, true);
        SceneManager.LoadScene("Scene2");
    }

    public void MainDoorClick()
    {
        gameController.UpdateGreenBar(0.02f, false);
        SceneManager.LoadScene("Scene3");
    }
}
