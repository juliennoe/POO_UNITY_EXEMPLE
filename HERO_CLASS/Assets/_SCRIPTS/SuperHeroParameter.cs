using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHeroParameter : HeroParameter
{
    public void SuperHit()
    {
        Debug.Log("SuperHit 100 points");
    }

    public void SuperDefend()
    {
        Debug.Log("block 10 points");
    }
}
