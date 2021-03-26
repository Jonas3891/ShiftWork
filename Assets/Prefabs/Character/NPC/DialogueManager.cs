using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;

    float distance;
    float curresponseTracker = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;



    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    private void OnMouseOver()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            curresponseTracker++;
            if(curresponseTracker >= npc.playerDialogue.Length - 1)
            {
                curresponseTracker = npc.playerDialogue.Length - 1;
            }
        }
        else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            curresponseTracker--;
            if(curresponseTracker < 0)
            {
                curresponseTracker = 0;
            }
        }
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if(distance <= 2.5f)
        {
            if (Input.GetKeyDown(KeyCode.E) && isTalking == false) 
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
            {
                EndDialogue();
            }

            if(curresponseTracker == 0 && npc.playerDialogue.Length >= 0)
            {
                playerResponse.text = npc.playerDialogue[0];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[1];
                }
            }

            else if(curresponseTracker == 1 && npc.playerDialogue.Length >= 1)
            {
                playerResponse.text = npc.playerDialogue[1];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[2];
                }
            }

            else if (curresponseTracker == 2 && npc.playerDialogue.Length >= 2)
            {
                playerResponse.text = npc.playerDialogue[2];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[3];
                }
            }

        }
    }
    void StartConversation()
    {
        isTalking = true;
        curresponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }

}
