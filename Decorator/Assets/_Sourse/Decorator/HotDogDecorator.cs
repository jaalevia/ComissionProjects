using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HotDogDecorator : ABaseHotDog
{
    public ABaseHotDog HotDog { get; protected set; }
    //конструктор
    public HotDogDecorator(string name, int cost, int weight, ABaseHotDog hotDog) : base(name, cost, weight)
    {
        HotDog = hotDog;
    }

    public override int GetCost() => HotDog.GetCost();
    public override int GetWeight() => HotDog.GetWeight();
}
