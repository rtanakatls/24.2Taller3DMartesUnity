using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger2 : DialogTrigger
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Execute();
        }
    }
}
