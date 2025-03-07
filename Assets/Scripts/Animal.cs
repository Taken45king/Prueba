using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string name;
    public int age;
    public string gender;

    public Animal(string _name, int _age, string _gender)
    {
        name = _name;
        age = _age;
        gender = _gender;
    }

    public virtual void Move()
    {
        Debug.Log("Animal se mueve");
    }


    /* public int _hungerLimit = 5;
     private int _consumedFood;
     private void Start()
     {
         Debug.Log(HasEat());
         Debug.Log(HasEat());
         Debug.Log(HasEat());
         Debug.Log(HasEat());
         Debug.Log(HasEat());
     }

     public bool HasEat()
     {
         _consumedFood += 1;
         if (_consumedFood >= _hungerLimit)
         {
             _consumedFood = 0;
             return true;
         }
         return false;

     }*/

}
