using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swaprole : MonoBehaviour
{
    public GameObject roledisplayasSurvival;
    public GameObject roledisplayasHunter;
    [SerializeField]
    private string Role = "Survival"; //Dont destroyonload & Instance
    // Start is called before the first frame update
    public void Swaproleforplay()
    {
        if (Role == "Survival")
            Role = "Hunter";
        else
            Role = "Survival";
        ChangeDisplay();
    }
    public void ChangeDisplay()
    {
        if (Role == "Survival")
        {
            roledisplayasSurvival.SetActive(true);
            roledisplayasHunter.SetActive(false);
        }
        else
        {
            roledisplayasHunter.SetActive(true);
            roledisplayasSurvival.SetActive(false);
        }
    }
}
