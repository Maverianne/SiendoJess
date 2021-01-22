using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int empathy;


    public PlayerData(GameManager player)
    {
        empathy = player.empathy;
    }
}
