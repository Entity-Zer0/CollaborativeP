using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static CharacterMovement Instance;

    public GameObject player;
    public float speed = 0.5f;

    public List<string> myInventory;

    public bool doorLocked = true;
    public bool inventoryFull = false;
    


    // Start is called before the first frame update
    public void Awake()
    {
        if(Instance == null)
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
        //myInventory.RemoveAt(3);
        //myInventory.Count

       
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

       /* if(myInventory.Count >= 3)
        {
            inventoryfull = true;
        }

        if (myInventory.Count < 3)
        {
            inventoryfull = false;
        }*/

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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    public void addItem(string item)
    {
        myInventory.Add(item);
    }
}
