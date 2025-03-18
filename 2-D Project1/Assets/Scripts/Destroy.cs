using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public CharacterDict player;

    public void OnMouseDown() 
    {
        if (player.manaBar > 0)
        {
            Destroy(gameObject);
        }
        --player.manaBar;
        player.DisplayMana();
    }



    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterDict>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
