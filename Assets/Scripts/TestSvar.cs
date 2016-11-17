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

                var button = GameObject.Find("Button").GetComponentInChildren<Text>().text;
                var button1 = GameObject.Find("Button (1)").GetComponentInChildren<Text>().text;
                var button2 = GameObject.Find("Button (2)").GetComponentInChildren<Text>().text;
                var button3 = GameObject.Find("Button (3)").GetComponentInChildren<Text>().text;

                //if (item.Key==button|| item.Key == button1||item.Key==button2|| item.Key == button3)
                //{
                //    if (mg.derp.ContainsKey(button))
                //    {

                //    }
                //}
                
                
                if (mg.derp.ContainsKey(button) && mg.derp.ContainsValue(true) == true) 
                {
                    var shit = GameObject.Find("Button").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
              else  if (mg.derp.ContainsKey(button1) && mg.derp.ContainsValue(true) == true)
                {
                    var shit = GameObject.Find("Button (1)").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
             else   if (mg.derp.ContainsKey(button2) && mg.derp.ContainsValue(true) == true)
                {
                    var shit = GameObject.Find("Button (2)").GetComponent<Button>();
                    ColorBlock newcolorBlock = shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                    shit.GetComponent<Button>().colors = newcolorBlock;
                }
             else   if (mg.derp.ContainsKey(button3) && mg.derp.ContainsValue(true) == true)
                {
                    var shit = GameObject.Find("Button (3)").GetComponent<Button>();
                    ColorBlock newcolorBlock=shit.colors;

                    newcolorBlock.normalColor = new Color(0, 1, 0, 1);
                   shit.GetComponent<Button>().colors = newcolorBlock;
                }

                mg.miniGameTrigger = false;
                StartCoroutine(mg.miniGameComplete());
               
            }
        }
    }
}
