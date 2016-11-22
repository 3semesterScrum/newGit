using UnityEngine;
using System.Collections;

public class TimeBasedMiniGame : MonoBehaviour
{
    public float waitTime = 0;
    public bool call = true;
    int rndNumber;
    public MiniGameManager mg;
    float collisionTimer = 0;
    void Update()
    {
        collisionTimer += Time.deltaTime;
        waitTime += Time.deltaTime;
        if (waitTime > 30 && call == true)
        {
            rndNumber = Random.Range(1, 3);
            Debug.Log("Rnd Nr: " + rndNumber);
            switch (rndNumber)
            {
                case 1:
                    mg.LoadQuestion(
                        "Nej, i kælderen skal jeg sidde ned, med mindre køretøjet ikke har et sæde. I dette tilfælde skal jeg anvende hjelm.", true,
                        "Ja jeg må gerne stå op når jeg kører rundt.", false,
                        "Det bestemmer jeg selv", false,
                        "Det skaber ingen problemer, så det er ok", false,
                        "Skal du sidde ned under kørsel alle steder på AUH?");
                    break;
                case 2:
                    mg.LoadQuestion(
                        "Så mange som der kan være på bussen - både stående og siddende.", false,
                        "Der må være det antal patienter, som der er sæder til - ud over chaufførs eget sæde.", true,
                        "Kun én passager ad gangen, uanset, antallet af sæder.", false,
                        "Du vurdere selv hvor mange det er forsvarligt at køre med på bussen.", false,
                        "Hvor mange passagerer må der være på en patient bus?");
                    break;
                case 3:
                    mg.LoadQuestion(
                        "", false,
                        "Ja, jeg må gerne høre musik.", false,
                        "Nej, jeg skal kunne høre hvad der sker omkring mig.", true,
                        "", false,
                        "Må du høre musik eller bære hørebøffer under transport?");
                    break;
                default:
                    Debug.Log(rndNumber);
                    break;
            }
            call = false;
            mg.MiniGameStart(true);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (collisionTimer > 60)
        {
            if (col.gameObject.name == "Visitor")
            {
                rndNumber = Random.Range(1, 3);
                switch (rndNumber)
                {
                    case 1:
                        mg.LoadQuestion(
                            "Råber til modkørende at patienten er ved at dø, så de skal holde til side.", false,
                            "Forventer at modkørende kan se patienten er dårlig og giver mig plads.", false,
                            "Sætter farten ned og signalere, at du udfører en akutkørsel og at modkørende skal give plads.", true,
                            "Du giver den fuld gas og satser på at du kan komme forbi.", false,
                            "Du kommer kørende med en patient i en seng, der hurtigt skal frem, Du møder modkørende ved en smal passage, hvad gør du?");
                        break;
                    case 2:
                        mg.LoadQuestion(
                           "Ringer til alarm tlf. og venter på beredskabet kommer og tørre op.", true,
                           "Skynder dig at tørre op.", false,
                           "Åbner et brandskab og spuler med vand.", false,
                           "Lader det ligge og kører videre.", false,
                           "Du har tabt en dunk med sprit på gulvet. Hvad gør du?");
                        break;
                    case 3:
                        mg.LoadQuestion(
                           "Ikke noget, jeg har travlt og parkere med det samme.", false,
                           "Jeg må parkere hvor jeg vil, så længe det ikke er midt på gangen.", false,
                           "Jeg må parkere hvor jeg vil.", false,
                           "Jeg er opmærksom på ikke at parkere foran flugtveje, brandskabe og elevator.", true,
                           "Du skal parkere dit køretøj. Hvad er du særligt opmærksom på?");
                        break;
                    default:
                        break;
                }
                collisionTimer = 0;
            }
            if (col.gameObject.name == "Wall")
            {
                rndNumber = Random.Range(1, 3);
                switch (rndNumber)
                {
                    case 1:
                        mg.LoadQuestion(
                            "Råber til modkørende at patienten er ved at dø, så de skal holde til side.", false,
                            "Forventer at modkørende kan se patienten er dårlig og giver mig plads.", false,
                            "Sætter farten ned og signalere, at du udfører en akutkørsel og at modkørende skal give plads.", true,
                            "Du giver den fuld gas og satser på at du kan komme forbi.", false,
                            "Du kommer kørende med en patient i en seng, der hurtigt skal frem, Du møder modkørende ved en smal passage, hvad gør du?");
                        break;
                    case 2:
                        mg.LoadQuestion(
                           "Ringer til alarm tlf. og venter på beredskabet kommer og tørre op.", true,
                           "Skynder dig at tørre op.", false,
                           "Åbner et brandskab og spuler med vand.", false,
                           "Lader det ligge og kører videre.", false,
                           "Du har tabt en dunk med sprit på gulvet. Hvad gør du?");
                        break;
                    case 3:
                        mg.LoadQuestion(
                           "Ikke noget, jeg har travlt og parkere med det samme.", false,
                           "Jeg må parkere hvor jeg vil, så længe det ikke er midt på gangen.", false,
                           "Jeg må parkere hvor jeg vil.", false,
                           "Jeg er opmærksom på ikke at parkere foran flugtveje, brandskabe og elevator.", true,
                           "Du skal parkere dit køretøj. Hvad er du særligt opmærksom på?");
                        break;
                    default:
                        break;
                }
                collisionTimer = 0;
            }
            if (col.gameObject.name == "Tboner")
            {
                rndNumber = Random.Range(1, 3);
                switch (rndNumber)
                {
                    case 1:
                        mg.LoadQuestion(
                            "Råber til modkørende at patienten er ved at dø, så de skal holde til side.", false,
                            "Forventer at modkørende kan se patienten er dårlig og giver mig plads.", false,
                            "Sætter farten ned og signalere, at du udfører en akutkørsel og at modkørende skal give plads.", true,
                            "Du giver den fuld gas og satser på at du kan komme forbi.", false,
                            "Du kommer kørende med en patient i en seng, der hurtigt skal frem, Du møder modkørende ved en smal passage, hvad gør du?");
                        break;
                    case 2:
                        mg.LoadQuestion(
                           "Ringer til alarm tlf. og venter på beredskabet kommer og tørre op.", true,
                           "Skynder dig at tørre op.", false,
                           "Åbner et brandskab og spuler med vand.", false,
                           "Lader det ligge og kører videre.", false,
                           "Du har tabt en dunk med sprit på gulvet. Hvad gør du?");
                        break;
                    case 3:
                        mg.LoadQuestion(
                           "Ikke noget, jeg har travlt og parkere med det samme.", false,
                           "Jeg må parkere hvor jeg vil, så længe det ikke er midt på gangen.", false,
                           "Jeg må parkere hvor jeg vil.", false,
                           "Jeg er opmærksom på ikke at parkere foran flugtveje, brandskabe og elevator.", true,
                           "Du skal parkere dit køretøj. Hvad er du særligt opmærksom på?");
                        break;
                    default:
                        break;
                }
                collisionTimer = 0;
            }
            mg.MiniGameStart(true);
        }
    }
}
