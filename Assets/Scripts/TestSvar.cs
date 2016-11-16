using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TestSvar : MonoBehaviour {

  public MiniGameManager mg;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void checkAnswear()
    {
        //var dip=   gameObject.GetComponent<Text>().text;
        //var dip = GameObject.Find("Button (3)").GetComponentInChildren<Text>().text;
        
        var dip = gameObject.GetComponentInChildren<Text>().text;
        //Debug.Log(gameObject.GetComponent<Text>().text);

        foreach (var item in mg.derp)
        {
            if (dip == item.Key && item.Value == true)
            {
                ColorBlock colorBlock = gameObject.GetComponent<Button>().colors;
                colorBlock.highlightedColor = new Color(0, 1, 0, 1);
                gameObject.GetComponent<Button>().colors = colorBlock;
                mg.miniGameTrigger = false;
               // mg.miniGameComplete();
               // StartCoroutine(mg.miniGameComplete());
            }
            else if (dip == item.Key && item.Value == false)
            {
                ColorBlock colorBlock = gameObject.GetComponent<Button>().colors;
                colorBlock.highlightedColor = new Color(1, 0, 0, 1);
                gameObject.GetComponent<Button>().colors = colorBlock;
            }
        }
    }
}
