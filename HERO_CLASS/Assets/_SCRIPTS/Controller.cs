using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // creation d'instance de classe
    public HeroParameter hero1 = new HeroParameter();
    public HeroParameter hero2 = new HeroParameter();

    public SuperHeroParameter superHero1 = new SuperHeroParameter();

    void Start()
    {
        // Lecture des valeurs par défaut présente dans la classe
        Debug.Log(hero1.m_Username);
        Debug.Log(hero1.m_Damage);
        Debug.Log(hero1.m_Mana);
        Debug.Log(hero1.m_Boost);

        // Lecture des methodes de classe
        hero1.Hit();
        hero1.Defend();

        // Lecture des valeurs par défaut présente dans la classe 
        Debug.Log(hero2.m_Username);
        Debug.Log(hero2.m_Damage);
        Debug.Log(hero2.m_Mana);
        Debug.Log(hero2.m_Boost);

        // RéEcriture des valeurs de la classe
        hero2.m_Username = "charly";
        hero2.m_Damage = 50;
        hero2.m_Mana = 5;
        hero2.m_Boost = false;

        // nouvelles valeurs pour l'instance hero2
        Debug.Log(hero2.m_Username);
        Debug.Log(hero2.m_Damage);
        Debug.Log(hero2.m_Mana);
        Debug.Log(hero2.m_Boost);

        // La classe SuperHeroParameter hérite de HeroParameter
        // ce qui lui permet d'acceder aux valeurs de la classe HeroParameter
        Debug.Log(superHero1.m_Username);
        Debug.Log(superHero1.m_Damage);
        Debug.Log(superHero1.m_Mana);
        Debug.Log(superHero1.m_Boost);

        superHero1.Hit();
        superHero1.Defend();

        superHero1.SuperHit();
        superHero1.SuperDefend();
    }

}
