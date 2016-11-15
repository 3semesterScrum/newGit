using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MiniGameManager : MonoBehaviour {

    Dictionary<string, bool> derp = new Dictionary<string, bool>();
    public bool miniGameTrigger;
    public GameObject panel;
    public Text Question;
   // public Dropdown answears;
    public Text svar1;
    public Text svar2;
    public Text svar3;
    public Text svar4;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            miniGameStart(miniGameTrigger=true);
            Debug.Log(miniGameTrigger);
            Debug.Log("p pressed");
        }
	}

    public void miniGameStart( bool miniGameTrigger)
    {
        if (miniGameTrigger)
        {
            Time.timeScale = 0;
            setMiniGame();
            panel.SetActive(true);
        }
    }

    public void setMiniGame()
    {
        svar1.text = "beef";
        svar2.text = "idc";
        svar3.text = "jerky";
        svar4.text = " shit";
        dostuff();
        foreach (var item in derp)
        {
            svar1.text = item.Key;
                svar2.text = item.Key;

            }
    }
    public void dostuff()
    {

        derp.Add("alalala", false);
        derp.Add("akraba", false);
        derp.Add("flodfnsj", false);
        derp.Add("correct", true);

    }
    


}
