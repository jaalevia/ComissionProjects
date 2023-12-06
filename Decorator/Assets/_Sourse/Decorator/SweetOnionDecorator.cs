using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetOnionDecorator : HotDogDecorator
{
    //конструктор
    public SweetOnionDecorator(string name, int cost, int weight, ABaseHotDog hotDog) : base(name, cost, weight, hotDog)
    {
    }
    public override int GetCost() => HotDog.GetCost() + Cost;
    public override int GetWeight() => HotDog.GetWeight() + Weight;
}
