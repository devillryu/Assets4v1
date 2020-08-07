using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionjoystick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Action()
        {
            if(Swaprole.chooserole.Role == "Survival")
            {
                //SurvivalAction()
            }
            else
            {
                print("r");
                //HunterAction()
            }
        }
}
