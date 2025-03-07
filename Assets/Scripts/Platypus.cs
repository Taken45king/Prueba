using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platypus : Animal, IOviparos
{
    public Platypus(string _name, int _age, string _gender) : base(_name, _age, _gender)
    {

    }

    public bool EggsHaveHatched()
    {
        return true;
    }

    public void LayEggs()
    {
        
    }

    public void ProtecEggs(int _numberofDays)
    {

    }
}
