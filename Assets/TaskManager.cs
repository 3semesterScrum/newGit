using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    [SerializeField]private List<Text> tasks = new List<Text>(4);
    public int objectiveCounter = 0;
    // Use this for initialization
    void Start()
    {
        CreateTasks(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckforObjective(Vector3 position)
    {
        FindImages CheckMark = tasks[objectiveCounter].GetComponent<FindImages>();
        CheckMark.checkboxes[1].color = new Color(255, 255, 255, 255);
    }

    public void CreateTasks(int number)
    {
        switch (number)
        {
            case 0:
                string text = "Go over here";
                tasks[0].text = text;
              // task.transform.parent = gameObject.transform;
              //  task.rectTransform.pivot = new Vector2(0, 1);
              //  task.rectTransform.anchorMin = new Vector2(0, 1);
              //  task.rectTransform.anchorMax = new Vector2(0, 1);
              //  task.rectTransform.anchoredPosition = new Vector2(0, 0);
              //  task.rectTransform.sizeDelta = new Vector2(270, 16);
              //  task.rectTransform.localPosition = new Vector3(25, -5);
              //  tasks.Add(task);
              //  Instantiate(task);
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }
    }
}
