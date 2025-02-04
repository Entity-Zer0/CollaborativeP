using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDict : MonoBehaviour
{
    public string itemName;
    public CharacterDict myPlayer;
    public int itemNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<CharacterDict>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddItem();
        Destroy(gameObject);
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
}
