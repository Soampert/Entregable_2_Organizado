using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP: MonoBehaviour
{
    private bool IsGameOver;
    private int playerHP = 150;
    public int Damage = 60;


    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerHP - Damage;



    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOver == false)
        {
                if (playerHP <= 0)
                {
                    Debug.Log("Te has quedado sin vida… GAME OVER");
                }   
            
                else if (playerHP <= 30)
                {
                    Debug.Log("¡¡¡Tienes poca vida!!!");
                }   
            
                else
                {
                    Debug.Log("Vas bien de vida: tienes " + playerHP + " puntos de vida");
                }   
        }

        else
        {
            Debug.Log($"IsGameOver");

        }
    }
}

