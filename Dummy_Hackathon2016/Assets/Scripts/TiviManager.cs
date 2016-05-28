using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TiviManager : MonoBehaviour {

    Image img;
    public Sprite[] sprite = new Sprite[2];

	// Use this for initialization
	void Start () {
        img = gameObject.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void TiviClick()
    {
        if (CheckTiviOn())
        {
            img.sprite = sprite[0];
        }
        else
        {
            img.sprite = sprite[1];
        }
        StartCoroutine(TurnOnTivi());
    }

    bool CheckTiviOn()
    {
        if (img.sprite.name == "tivi-offpng")
        {
            return false;
        }
        return true;
    }

    IEnumerator TurnOnTivi()
    {
        int rand = Random.Range(5, 10);
        yield return new WaitForSeconds(rand);
        if (!CheckTiviOn())
        {
            img.sprite = sprite[1];
        }
    }
}
