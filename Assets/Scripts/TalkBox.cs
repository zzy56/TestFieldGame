using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBox : MonoBehaviour
{

    public SpriteRenderer talkOptionBox;
    public SpriteRenderer dialogueBox;

    [SerializeField]
    private bool m_canShowDialogue;

    // Start is called before the first frame update
    void Start()
    {
        talkOptionBox.enabled = false;
        dialogueBox.enabled = false;
        m_canShowDialogue = false;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player Entering");
            talkOptionBox.enabled = true;
            m_canShowDialogue = true;

        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Exiting");
            talkOptionBox.enabled = false;
            m_canShowDialogue = false;
            dialogueBox.enabled = false;
        }
        

    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.X) && m_canShowDialogue)
        {
            dialogueBox.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.A) && m_canShowDialogue)
        {
            dialogueBox.enabled = false;
        }

    }
}
