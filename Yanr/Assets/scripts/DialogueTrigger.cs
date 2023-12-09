using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public DialogueRunner dialogueRunner;

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "visitor center")
        {
            Debug.Log("collision");
            dialogueRunner.StartDialogue("WeekOne");
        }

        if (col.gameObject.name == "wildlife center")
        {
            Debug.Log("collision");
            dialogueRunner.StartDialogue("WeekTwoBigDecisions");
            
        }

        if (col.gameObject.name == "tourism center")
        {
            Debug.Log("collision");
            
        }
    }
}
