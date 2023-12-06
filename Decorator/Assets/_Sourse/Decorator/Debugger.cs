using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    [SerializeField] private HotDogSO classicHotDogSO;
    [SerializeField] private HotDogSO caesarHotDogSO;
    [SerializeField] private HotDogSO meatHotDogSO;
    [SerializeField] private HotDogSO picklesSO;
    [SerializeField] private HotDogSO sweetOnionSO;

    private void Start()
    {
        ClassicHotDog hotDogNum1 = new ClassicHotDog(classicHotDogSO.Name, classicHotDogSO.Cost, classicHotDogSO.Weight);
        PicklesDecorator pickledDogNum1 = new PicklesDecorator(picklesSO.Name, picklesSO.Cost, picklesSO.Weight, hotDogNum1);
        SweetOnionDecorator sweetOnionDogNum1 = new SweetOnionDecorator(sweetOnionSO.Name, sweetOnionSO.Cost, sweetOnionSO.Weight, hotDogNum1);

        CaesarHotDog hotDogNum2 = new CaesarHotDog(caesarHotDogSO.Name, caesarHotDogSO.Cost, caesarHotDogSO.Weight);
        PicklesDecorator pickledDogNum2 = new PicklesDecorator(picklesSO.Name, picklesSO.Cost, picklesSO.Weight, hotDogNum2);
        SweetOnionDecorator sweetOnionDogNum2 = new SweetOnionDecorator(sweetOnionSO.Name, sweetOnionSO.Cost, sweetOnionSO.Weight, hotDogNum2);

        MeatHotDog hotDogNum3 = new MeatHotDog(meatHotDogSO.Name, meatHotDogSO.Cost, meatHotDogSO.Weight);
        PicklesDecorator pickledDogNum3 = new PicklesDecorator(picklesSO.Name, picklesSO.Cost, picklesSO.Weight, hotDogNum3);
        SweetOnionDecorator sweetOnionDogNum3 = new SweetOnionDecorator(sweetOnionSO.Name, sweetOnionSO.Cost, sweetOnionSO.Weight, hotDogNum3);

        Debug.Log($"{hotDogNum1.Name}({hotDogNum1.GetWeight()}г) - {hotDogNum1.GetCost()}р. " + 
            $"\nДополнительная информация:" + 
            $"\n{hotDogNum1.Name}{pickledDogNum1.Name}({pickledDogNum1.GetWeight()}г) - {pickledDogNum1.GetCost()}р." + 
            $"\n{hotDogNum1.Name}{sweetOnionDogNum1.Name}({sweetOnionDogNum1.GetWeight()}г) - {sweetOnionDogNum1.GetCost()}р.");

        Debug.Log($"{hotDogNum2.Name}({hotDogNum2.GetWeight()}г) - {hotDogNum2.GetCost()}р. " + 
            $"\nДополнительная информация:" + 
            $"\n{hotDogNum2.Name}{pickledDogNum2.Name}({pickledDogNum2.GetWeight()}г) - {pickledDogNum2.GetCost()}р." + 
            $"\n{hotDogNum2.Name}{sweetOnionDogNum2.Name}({sweetOnionDogNum2.GetWeight()}г) - {sweetOnionDogNum2.GetCost()}р.");

        Debug.Log($"{hotDogNum3.Name}({hotDogNum3.GetWeight()}г) - {hotDogNum3.GetCost()}р. " + 
            $"\nДополнительная информация:" + 
            $"\n{hotDogNum3.Name}{pickledDogNum3.Name}({pickledDogNum3.GetWeight()}г) - {pickledDogNum3.GetCost()}р." + 
            $"\n{hotDogNum3.Name}{sweetOnionDogNum3.Name}({sweetOnionDogNum3.GetWeight()}г) - {sweetOnionDogNum3.GetCost()}р.");
    }
}
