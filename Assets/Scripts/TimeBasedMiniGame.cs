using UnityEngine;
using System.Collections;

public class TimeBasedMiniGame : MonoBehaviour
{
    public float waitTime = 0;
    public bool call = true;
    public MiniGameManager mg;

    void Update()
    {

        waitTime += Time.deltaTime;

        if (waitTime > 5 && call == true)
        {
            call = false;
            mg.miniGameStart(true);
        }
    }
}
