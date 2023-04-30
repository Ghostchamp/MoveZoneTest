using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    Vector3 diceVelocity;

    private void FixedUpdate()
    {
        diceVelocity = RollCube.diceVelocity;
    }

    private void OnTriggerStay(Collider other)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch(other.gameObject.name)
            {
                case "Side1":
                    Debug.Log("20");
                    break;
                case "Side2":
                    Debug.Log("19");
                    break;
                case "Side3":
                    Debug.Log("18");
                    break;
                case "Side4":
                    Debug.Log("17");
                    break;
                case "Side5":
                    Debug.Log("16");
                    break;
                case "Side6":
                    Debug.Log("15");
                    break;
                case "Side7":
                    Debug.Log("14");
                    break;
                case "Side8":
                    Debug.Log("13");
                    break;
                case "Side9":
                    Debug.Log("12");
                    break;
                case "Side10":
                    Debug.Log("11");
                    break;
                case "Side11":
                    Debug.Log("10");
                    break;
                case "Side12":
                    Debug.Log("9");
                    break;
                case "Side13":
                    Debug.Log("8");
                    break;
                case "Side14":
                    Debug.Log("7");
                    break;
                case "Side15":
                    Debug.Log("6");
                    break;
                case "Side16":
                    Debug.Log("5");
                    break;
                case "Side17":
                    Debug.Log("4");
                    break;
                case "Side18":
                    Debug.Log("3");
                    break;
                case "Side19":
                    Debug.Log("2");
                    break;
                case "Side20":
                    Debug.Log("1");
                    break;


            }
        }
    }
}
