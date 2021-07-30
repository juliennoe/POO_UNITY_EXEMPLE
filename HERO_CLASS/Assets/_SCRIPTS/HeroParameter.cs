using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class HeroParameter 
{
    private string username = "julien";
    public string m_Username { get { return username; } set { username = value; } }

    private int damage = 100;
    public int m_Damage { get { return damage; } set { damage = value; } }

    private int mana = 10;
    public int m_Mana { get { return mana; } set { mana = value; } }

    private bool boost = true;
    public bool m_Boost { get { return boost; } set { boost = value; } }


    public void Hit()
    {
        Debug.Log("hit 10 points");
    }

    public void Defend()
    {
        Debug.Log("block 10 points");
    }
}
