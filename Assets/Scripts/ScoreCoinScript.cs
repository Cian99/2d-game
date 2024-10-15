using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCoinScript : MonoBehaviour
{

    private static List<GameObject> coins = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // if a coin object is a clone they should be added to the coins list
        // this makes it simple remove coins that may cause isssue when game is reset
        if (gameObject.name.Contains("Clone"))
        {
            coins.Add(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // destroy coin on 2D collision and increase the score
        // the player is the only onject in the game that can collider with the coins
        GameManagerScript.score++;
        Destroy(this.gameObject);
    }

    public static void DestroyAllCloneCoins()
    {
        // this destroys clone coins when needed
        foreach(GameObject go in coins)
        {
            Destroy(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
