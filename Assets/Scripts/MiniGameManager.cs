using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MiniGameManager : MonoBehaviour {

  public Dictionary<string, bool> derp = new Dictionary<string, bool>();
 public  List<string> muligheder = new List<string>();
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

    public IEnumerator miniGameComplete()
    {
        if (miniGameTrigger==false)
        {
            Time.timeScale = 1;
            print(Time.time);
            yield return new WaitForSeconds(5);
            panel.SetActive(false);
            print(Time.time);
            
            
        }
    }

    public void setMiniGame()
    {
        svar1.text = "option a";
        svar2.text = "option b";
        svar3.text = "option c";
        svar4.text = "option d";
        dostuff();
        foreach (var item in derp)
        {
            if (derp.Count>0)
            {
            muligheder.Add(item.Key);
            Debug.Log(item.Key);

            }
            else
            {
                Debug.LogError("doStuff()  blev ikke kørt eller er broken");
            }
        }

        svar1.text = muligheder[0];
        svar2.text = muligheder[1];
        svar3.text = muligheder[2];
        svar4.text = muligheder[3];



    }
    public void dostuff(string optionA,bool correct, string optionb, bool correct1, string optionc, bool correct2, string optiond, bool correct3,string question)
    {

        derp.Add(optionA, correct);
        derp.Add(optionb, correct1);
        derp.Add(optionc, correct2);
        derp.Add(optiond, correct3);
        Question.text = question;

    }
    public void dostuff()
    {

        derp.Add("optionA", false);
        derp.Add("optionb", false);
        derp.Add("optionc", true);
        derp.Add("optiond",true);

    }


   

}
