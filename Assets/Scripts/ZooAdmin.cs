using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooAdmin : MonoBehaviour
{
    private Animal elefante;
    private Animal ornitorrinco;
    private Animal panther;
    private void Start()
    {
        elefante = new Animal("Elefante ", 19, " Macho");
        ornitorrinco = new Animal("Ornitorrinco ", 5," Hembra");
        panther = new Panther("Pantera ", 9, " Hembra");
        Debug.Log(panther.name);

        elefante.Move();
        ornitorrinco.Move();
        panther.Move();
    }
}
