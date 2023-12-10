using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public DialogueRunner dialogueRunner;

    void Start(){
        dialogueRunner.StartDialogue("Start");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "visitor center")
        {
            Debug.Log("collision");
            dialogueRunner.StartDialogue("WeekOne");
        }

        if (col.gameObject.name == "w1small")
        {
            dialogueRunner.StartDialogue("WeekOneSmall");
        }

        if (col.gameObject.name == "wildlife center")
        {
            Debug.Log("collision");
            dialogueRunner.StartDialogue("WeekTwo");
            
        }

        if (col.gameObject.name == "w2small")
        {
            dialogueRunner.StartDialogue("WeekTwoSmall");
        }

        if (col.gameObject.name == "tourism center")
        {
            Debug.Log("collision");
            dialogueRunner.StartDialogue("WeekThreeBig");
            
        }

        if (col.gameObject.name == "w3small")
        {
            dialogueRunner.StartDialogue("WeekThreeSmall");
        }
    }
}
