using UnityEngine;
using System.Collections;

public class TimeBasedMiniGame : MonoBehaviour
{
    float waitTime = 0;
    bool call = true;
    public MiniGameManager mg;

    void Update()
    {
        Debug.Log("WaitTime: "+waitTime + call);
        if (waitTime < 5)
        {
            waitTime += Time.deltaTime;
        }
        if (waitTime > 5 && call == true)
        {
            call = false;
            mg.dostuff();
            mg.miniGameStart(true);
        }
    }


}
