using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    [SerializeField] private List<Text> tasks = new List<Text>(4);
    [SerializeField] private List<GameObject> taskObjects = new List<GameObject>();
    private int currentObjective = 0;
    public int objectiveCounter = 0;
    // Use this for initialization
    void Start()
    {
        int number = 0;
        foreach (GameObject gameObject in taskObjects)
        {
            gameObject.GetComponent<TaskCollision>().objectiveOrder = number;
            number++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckforObjective(Vector3 position)
    {
        objectiveCounter = 0;
        foreach (GameObject gameobject in taskObjects)
        {
            if(gameobject.GetComponent<TaskCollision>().OnTarget == true)
            {
                if(currentObjective == gameobject.GetComponent<TaskCollision>().objectiveOrder)
                {
                    FindImages CheckMark = tasks[objectiveCounter].GetComponent<FindImages>();
                    if (tasks[currentObjective].text != "")
                    {
                        CheckMark.checkboxes[1].color = new Color(255, 255, 255, 255);
                        currentObjective = gameobject.GetComponent<TaskCollision>().objectiveOrder + 1;
                        this.gameObject.GetComponent<TaskMiniGame>().TriggerMiniGame();
                    }

                }
            }
            objectiveCounter++;
        }
        
    }

    public void CreateTasks(int number)
    {
        string text;
        switch (number)
        {
            case 0:
                //Patientbus
                text = "Assister patient med transport";
                tasks[0].text = text;
                text = "Patient skal tilbage til patientstuen";
                tasks[1].text = text;
                text = "";
                tasks[2].text = text;
                text = "";
                tasks[3].text = text;
                break;
            case 1:
                //ElTruck
                text = "Afhent Kemikalier";
                tasks[0].text = text;
                text = "Levere kemikalier til lokale";
                tasks[1].text = text;
                text = "Afhent Kemikalier";
                tasks[2].text = text;
                text = "Lever kemikalier til lokale";
                tasks[3].text = text;
                break;
            case 2:
                //Fejeblad
                text = "Afhent seng ude foran patientstue";
                tasks[0].text = text;
                text = "Levere seng til vaskning";
                tasks[1].text = text;
                text = "afhent ny ren seng";
                tasks[2].text = text;
                text = "Levere ren seng til patientstuen";
                tasks[3].text = text;
                break;
            case 3:
                //Sengetransport
                text = "Parker ude foran patientstue";
                tasks[0].text = text;
                text = "Levere seng med patient";
                tasks[1].text = text;
                text = "kør seng tilbage til patientstuen";
                tasks[2].text = text;
                text = "";
                tasks[3].text = text;
                break;
            default:
                text = "Error in switchcase";
                foreach (Text t in tasks)
                {
                    t.text = text;
                }
                break;
        }
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].text == "")
            {
                tasks[i].GetComponent<FindImages>().checkboxes[0].color = new Color(255, 255, 255, 0);
            }
        }
    }
}
