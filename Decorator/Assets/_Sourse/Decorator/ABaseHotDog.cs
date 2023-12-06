using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ABaseHotDog
{
    public string Name { get; protected set; }
    public int Cost { get; protected set; }
    public int Weight { get; protected set; }

    //�����������
    public ABaseHotDog(string name, int cost, int weight)
    {
        Name = name;
        Cost = cost;
        Weight = weight;
    }

    public string GetName() => Name;
    public virtual int GetCost() => Cost;
    public virtual int GetWeight() => Weight;
}
