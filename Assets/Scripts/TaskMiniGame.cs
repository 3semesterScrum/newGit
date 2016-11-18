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
        int number = Random.Range(0,4);
        switch (number)
        {
            case 0:
                miniGameManager.dostuff("Ja", true, "Nej", false, "", false, "", false, "Du kører bag en gulvvaskemaskine. Er der noget du skal være særlig opmærksom på?");
                break;
            case 1:
                miniGameManager.dostuff("Køretøjets bremseevne og styreevne", true, "Dækkene kan ikke tåle vand", false, "Køretøjet ruster fordi der sprøjter vand op", false, "", false, "Hvad skal du være særligt opmærksom på ved kørsel på vådt underlag?");
                break;
            case 2:
                miniGameManager.dostuff("Du bliver svimmel", false, "Du kan miste kontrollen over køretøjet", true, "Din bremselængde bliver kortere", false, "Du risikerer at blive indkaldt til adfærdsregulerende samtale", true, " Hvilke kan der ske ved høj fart i skarpe sving");
                break;
            case 3:
                miniGameManager.dostuff("Kører, og lader slangerne hænge", false, "Plejepersonalet har sørget for at slanger og poser hænger korrekt, så du er klar til at køre", false, "Hiver slangerne ud af patienten, så sker der ikke noget under kørslen", false, "Får styr på slangerne før du kører, og vise yderste opmærksomhed ved tæt passage med øvrigt trafik, vægge mv", true, "Du skal til at køre med en seng hvor der hænger slanger og poser på siden. Hvad gør du?");
                break;
            default:
                miniGameManager.dostuff("Error: You fucked up", false, "Error: You fucked up", false, "Error: You fucked up", false, "Error: You fucked up", false, "Error Number: "+number);
                break;
        }
        miniGameManager.miniGameStart(true);
    }
}
