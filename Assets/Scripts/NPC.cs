using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;

    private bool isPlayerInRange = false;
    private bool isDialogueOpen = false;

    void Update()
    {
        if (isPlayerInRange && !isDialogueOpen && Input.GetKeyDown(KeyCode.E))
        {
            OpenDialogue();
        }

        if (isDialogueOpen)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Plane");
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                CloseDialogue();
            }
        }
    }

    void OpenDialogue()
    {
        isDialogueOpen = true;
        dialoguePanel.SetActive(true);
    }

    void CloseDialogue()
    {
        isDialogueOpen = false;
        dialoguePanel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            CloseDialogue();
        }
    }
}
