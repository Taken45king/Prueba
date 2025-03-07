using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panther : Animal
{
    public Panther(string _name, int _age, string _gender) : base(_name, _age, _gender)
    {

    }
    private void Start()
    {
        Move();
    }
    public override void Move()
    {
        base.Move();
        Debug.Log("Panther se mueve");
    }
}
