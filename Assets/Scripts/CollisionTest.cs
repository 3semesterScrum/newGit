using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {

    MiniGameManager mg;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Visitor")
        {
           // mg.dostuff();
            mg.miniGameStart(true);
            Debug.Log("vi har lavet noget minigame");
        }
    }
}
