using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    [SerializeField] protected List<string> texts;
    [SerializeField] protected float delay;


    protected void Execute()
    {
        TextController.Instance.SetUp(texts,delay);
    }

}
