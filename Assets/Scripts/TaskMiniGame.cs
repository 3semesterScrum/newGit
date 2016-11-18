using UnityEngine;
using System.Collections;

public class TaskMiniGame : MonoBehaviour
{
    [SerializeField]
    public MiniGameManager miniGameManager;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerMiniGame()
    {
        miniGameManager.miniGameStart(true);
    }
}
