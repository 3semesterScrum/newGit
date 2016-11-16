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

    public IEnumerable miniGameComplete()
    {
        if (miniGameTrigger==false)
        {
            Time.timeScale = 1;
            panel.SetActive(false);
            print(Time.time);
            yield return new WaitForSeconds(5);
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
    public void dostuff(string optionA,bool correct, string optionb, bool correct1, string optionc, bool correct2, string optiond, bool correct3)
    {

        derp.Add(optionA, correct);
        derp.Add(optionb, correct1);
        derp.Add(optionc, correct2);
        derp.Add(optiond, correct3);

    }
    public void dostuff()
    {

        derp.Add("optionA", false);
        derp.Add("optionb", false);
        derp.Add("optionc", false);
        derp.Add("optiond",true);

    }


    //public void checkAnswear()
    //{
    // //var dip=   gameObject.GetComponent<Text>().text;
    //  var dip= GameObject.Find("Button (3)").GetComponentInChildren<Text>().text;

    //    Debug.Log(dip);
    //    foreach (var item in derp)
    //    {
    //        if (dip==item.Key&&item.Value==true)
    //        {
    //            ColorBlock colorBlock = gameObject.GetComponent<Button>().colors;
    //            colorBlock.highlightedColor= new Color(0, 1, 0, 1);


    //        }
    //        else if(dip == item.Key && item.Value == false)
    //        {
    //            ColorBlock colorBlock = gameObject.GetComponent<Button>().colors;
    //            colorBlock.highlightedColor = new Color(1, 0, 0, 1);
    //        }
    //    }
    //}

}
