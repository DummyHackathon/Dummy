using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour {

    Image image;
    Image ClockBtn;
    // Use this for initialization
    void Start() {
        image = GameObject.Find("ClockImage").GetComponent<Image>();
        ClockBtn = GameObject.Find("Clock").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (image.fillAmount > 0)
        {
            image.fillAmount -= Time.fixedDeltaTime / 60;
        }
        
	}

    IEnumerator ScaleAfter()
    {
        Vector3 scale = ClockBtn.transform.localScale;
        scale.x = 0.85f;
        scale.y = 0.85f;
        ClockBtn.transform.localScale = scale;
        yield return new WaitForSeconds(0.15f);
        scale.x = 1f;
        scale.y = 1f;
        ClockBtn.transform.localScale = scale;
    }

    public void ScaleClock()
    {
        StartCoroutine(ScaleAfter());
    }
}
