using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timmy : MonoBehaviour
{
    private float mana = 100;

    public void Skill(float mana)
    {
        this.mana -= mana;

        if (this.mana >= 0) Debug.Log("Use Skill -> Current Mana : " + this.mana);
        else Debug.Log("The skill cannot be used.");

    }
}
