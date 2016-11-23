using UnityEngine;
using System.Collections;

public class CollisionBasedMiniGame : MonoBehaviour {

    public MiniGameManager mg;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Visitor")
        {
            mg.LoadQuestion("Ja", false, "Måske", false, "Idiot", true, "Nej", false, "Sup!");
            mg.MiniGameStart(true);
            Debug.Log("vi har lavet noget minigame");
        }
        if (col.gameObject.name == "TBonerMK2(Clone)")
        {
            mg.LoadQuestion("Ja", false, "Måske", false, "Idiot", true, "Nej", false, "Sup!");
            mg.MiniGameStart(true);
            Debug.Log("vi har lavet noget minigame");
        }
    }
}
