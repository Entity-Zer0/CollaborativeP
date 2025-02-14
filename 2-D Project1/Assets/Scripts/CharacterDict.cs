using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDict : MonoBehaviour
{
    public static CharacterDict Instance;

    public GameObject player;
    public float speed = 0.5f;
    public int manaBar = 1;

    public Dictionary<string, int> myInvDict = new Dictionary<string, int>();

    public TextMeshProUGUI inventoryDisplay;
    public TextMeshProUGUI manaDisplay;


    // Start is called before the first frame update
    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;

        }
        else
        {
            Destroy(gameObject);

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        //myInvDict.Add("Wand", 1);
        DisplayInventory();
        DisplayMana();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed;
            //Debug.Log("W Pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
            //Debug.Log("A Pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
            //Debug.Log("S Pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            //Debug.Log("D Pressed");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "Key")
        {
            Destroy(collision.gameObject);
        }*/

        if (collision.gameObject.tag == "Death")
        {
            Destroy(player);
        }
    }

    public void DisplayInventory()
    {
        inventoryDisplay.text = "Inventory\n\n";
        foreach (var item in myInvDict)
        {
            inventoryDisplay.text += " " + item.Key + ": " + item.Value + "\n";
        }

        
    }

    public void DisplayMana()
    {
        manaDisplay.text = "Mana = " + manaBar;
        //foreach (var item in myInvDict)
        {
            //manaDisplay.text += " " + item.Key + ": " + item.Value + "\n";
        }


    }





}


