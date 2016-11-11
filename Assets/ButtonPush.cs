using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ButtonPush : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private Image buttonImg;
    [SerializeField] private TaskManager taskManager;
    // Use this for initialization
    void Start()
    {
        buttonImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(buttonImg.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
        {
            buttonImg.color = Color.red;
            taskManager.CheckforObjective(new Vector3(0,0,0));
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (buttonImg.color == Color.red)
        {
            buttonImg.color = Color.white;
            taskManager.objectiveCounter++;
        }
    }
}
