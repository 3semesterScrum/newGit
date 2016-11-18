using UnityEngine;
using System.Collections;

public class CollisionBasedMiniGame : MonoBehaviour {

    public MiniGameManager mg;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Visitor")
        {
            mg.dostuff("Ja", false, "Måske", false, "Idiot", true, "Nej", false, "Sup!");
            mg.miniGameStart(true);
            Debug.Log("vi har lavet noget minigame");
        }
    }
}
