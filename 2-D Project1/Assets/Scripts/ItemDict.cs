using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemDict : MonoBehaviour
{
    public string itemName;
    public int objectIndex;

    public CharacterDict myPlayer;
    public DialogueManagerScript dialogueManager;
    public int itemNumber = 1;

    public GameObject pickUp;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterDict>();
        dialogueManager = FindObjectOfType<DialogueManagerScript>();
        pickUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        pickUp.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            Interact();
            AddItem();
            pickUp.SetActive(false);
            Destroy(gameObject);
        }
    }
    public void AddItem()
    {
        if(myPlayer.myInvDict.ContainsKey(itemName))
        {
            myPlayer.myInvDict[itemName]+= itemNumber;
        }
        else
        {
            myPlayer.myInvDict.Add(itemName, itemNumber);
        }
        myPlayer.DisplayInventory();
    }

    public void Interact()
    {
        dialogueManager.currentIndex = objectIndex;
    }
}
