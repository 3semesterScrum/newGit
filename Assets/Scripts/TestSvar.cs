using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TestSvar : MonoBehaviour
{

    public MiniGameManager mg;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

                StartCoroutine(mg.miniGameComplete());
            }
            else if (dip == item.Key && item.Value == false)
            {
                ColorBlock colorBlock = gameObject.GetComponent<Button>().colors;
                colorBlock.highlightedColor = new Color(1, 0, 0, 1);
                gameObject.GetComponent<Button>().colors = colorBlock;
                highlightRightAnswear();


                mg.miniGameTrigger = false;
                StartCoroutine(mg.miniGameComplete());

            }
        }
    }
    public void highlightRightAnswear()
    {
        var button = GameObject.Find("Button").GetComponentInChildren<Text>().text;
        var button1 = GameObject.Find("Button (1)").GetComponentInChildren<Text>().text;
        var button2 = GameObject.Find("Button (2)").GetComponentInChildren<Text>().text;
        var button3 = GameObject.Find("Button (3)").GetComponentInChildren<Text>().text;
        

        foreach (var item in mg.derp)
        {
            if (item.Value == true)
            {
                var bongo = item.Key;
                if (bongo==button)
                {
                    var shit = GameObject.Find("Button").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;
                    
                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
                 if (bongo == button1)
                {
                    var shit = GameObject.Find("Button (1)").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
                 if (bongo == button2)
                {
                    var shit = GameObject.Find("Button (2)").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
                 if (bongo == button3)
                {
                    var shit = GameObject.Find("Button (3)").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }

            }
        }

    }
}
