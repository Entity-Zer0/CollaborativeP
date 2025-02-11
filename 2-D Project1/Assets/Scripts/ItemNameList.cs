using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemNameList: MonoBehaviour
{

    public string itemName;
    public int objectIndex;

    public CharacterMovement myPlayer;
    public DialogueManagerScript dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterMovement>();
        dialogueManager = FindObjectOfType<DialogueManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myPlayer.addItem(itemName);
        Destroy(gameObject);
    }
}
