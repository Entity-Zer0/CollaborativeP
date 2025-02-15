using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public static Door Instance;
    public GameObject door;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && Input.GetKey(KeyCode.Space));
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //Other: SceneManager.LoadScene("SampleScene")
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
