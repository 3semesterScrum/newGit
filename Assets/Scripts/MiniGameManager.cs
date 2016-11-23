using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    //public TimeBasedMiniGame tm;
    public Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
    public List<string> muligheder = new List<string>();
    public bool miniGameTrigger;
    public GameObject panel;
    public Text question;
    // public Dropdown answears;
    public Text svar1;
    public Text svar2;
    public Text svar3;
    public Text svar4;

    // Use this for initialization
    void Start()
    {
        //Debug.Log(tm= GameObject.FindGameObjectWithTag("vehicle").GetComponent<TimeBasedMiniGame>());
       // panel = GameObject.Find("Panel");
        panel.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            MiniGameStart(miniGameTrigger = true);
            Debug.Log(miniGameTrigger);
            Debug.Log("p pressed");
        }
    }

    public void MiniGameStart(bool miniGameTrigger)
    {
                panel.SetActive(true);
        Debug.Log(panel);
     //  tm = GameObject.FindGameObjectWithTag("vehicle").GetComponent<TimeBasedMiniGame>();
        if (miniGameTrigger)
        {
            
            Time.timeScale = 0;
            SetMiniGame();
            //if (SceneManager.GetActiveScene().name=="Hospital")
            //{
                //GameObject.Find("BackgroundImage").SetActive(false);
                //GameObject.Find("Button").SetActive(false);
                //GameObject.Find("TaskManagerPanel").SetActive(false);
                //GameObject.Find("ActionButton").SetActive(false);

            //}

        }
    }

    public IEnumerator MiniGameComplete()
    {
        if (dictionary.Count == 4)
        {
            dictionary.Clear();
            muligheder.Clear();
        }
        if (miniGameTrigger == false)
        {
            Time.timeScale = 1;
            print(Time.time);
            //dictionary.Clear();
            //muligheder.Clear();
            yield return new WaitForSeconds(5);
            panel.SetActive(false);
            //if (SceneManager.GetActiveScene().name == "Hospital")
            //{
                //GameObject.Find("BackgroundImage").SetActive(true);
                //GameObject.Find("Button").SetActive(true);
                //GameObject.Find("TaskManagerPanel").SetActive(true);
                //GameObject.Find("ActionButton").SetActive(true);
            //}
            print(Time.time);
            //tm.call = true;
            //tm.waitTime = 0;
        }
    }

    public void SetMiniGame()
    {
        
        //svar1.text = "option adfsbjkbjdsfbdsfoidhgdbgbfdiugdfkjghoidshgkndghfdjbgfdiuhgfjgiufdbvkfdjgufdbjgbfdugbdjbiuefhvbjkfdbiuvfhdubfjfdsgudbjgkduigu";
        //svar2.text = "option b";
        //svar3.text = "option c";
        //svar4.text = "option d";
        //dostuff();
        foreach (var item in dictionary)
        {
            if (dictionary.Count > 0)
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
    public void LoadQuestion(string optionA, bool correct, string optionb, bool correct1, string optionc, bool correct2, string optiond, bool correct3, string question)
    {

        dictionary.Add(optionA, correct);
        dictionary.Add(optionb, correct1);
        dictionary.Add(optionc, correct2);
        dictionary.Add(optiond, correct3);
        this.question.text = question;

    }
    public void dostuff()
    {

        dictionary.Add("optionAjkdsgfiudsgiugfdioghiuofdhv8\nfidighgvfdihgifdhihifdhivhofdihiufdhvidoifvfdiovfdivhofdihbid", false);
        dictionary.Add("optionb", false);
        dictionary.Add("optionc", true);
        dictionary.Add("optiond", true);

    }




}
