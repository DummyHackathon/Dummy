using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroTextController : MonoBehaviour {

    float delayTime = 0.02f; //Delay 0.08s
    public AudioClip typeSound;
    Text textComp;
    string mess;
    public Button btn;
    bool isDone = false;

	// Use this for initialization
	void Start () {
        textComp = gameObject.GetComponent<Text>();
        mess = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in mess.ToCharArray())
        {
            textComp.text += letter;
            AudioSource.PlayClipAtPoint(typeSound, gameObject.transform.position);
            yield return 0;
            yield return new WaitForSeconds(delayTime);
        }
        yield return new WaitForSeconds(3);
        isDone = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (isDone)
        {
            SceneManager.LoadScene("Scene1");
        }
	}
}
