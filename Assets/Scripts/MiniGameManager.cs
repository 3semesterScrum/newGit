using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MiniGameManager : MonoBehaviour
{
    public TimeBasedMiniGame tm;
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
        if (miniGameTrigger)
        {
            Time.timeScale = 0;
            SetMiniGame();
            panel.SetActive(true);
        }
    }

    public IEnumerator MiniGameComplete()
    {
        if (miniGameTrigger == false)
        {
            Time.timeScale = 1;
            print(Time.time);
            dictionary.Clear();
            muligheder.Clear();
            yield return new WaitForSeconds(5);
            panel.SetActive(false);
            print(Time.time);
            tm.call = true;
            tm.waitTime = 0;
        }
    }

    public void SetMiniGame()
    {
        svar1.text = "option adfsbjkbjdsfbdsfoidhgdbgbfdiugdfkjghoidshgkndghfdjbgfdiuhgfjgiufdbvkfdjgufdbjgbfdugbdjbiuefhvbjkfdbiuvfhdubfjfdsgudbjgkduigu";
        svar2.text = "option b";
        svar3.text = "option c";
        svar4.text = "option d";
        dostuff();
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
