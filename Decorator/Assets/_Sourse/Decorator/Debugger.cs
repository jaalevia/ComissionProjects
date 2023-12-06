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

        Debug.Log($"{hotDogNum1.Name}({hotDogNum1.GetWeight()}�) - {hotDogNum1.GetCost()}�. " + 
            $"\n�������������� ����������:" + 
            $"\n{hotDogNum1.Name}{pickledDogNum1.Name}({pickledDogNum1.GetWeight()}�) - {pickledDogNum1.GetCost()}�." + 
            $"\n{hotDogNum1.Name}{sweetOnionDogNum1.Name}({sweetOnionDogNum1.GetWeight()}�) - {sweetOnionDogNum1.GetCost()}�.");

        Debug.Log($"{hotDogNum2.Name}({hotDogNum2.GetWeight()}�) - {hotDogNum2.GetCost()}�. " + 
            $"\n�������������� ����������:" + 
            $"\n{hotDogNum2.Name}{pickledDogNum2.Name}({pickledDogNum2.GetWeight()}�) - {pickledDogNum2.GetCost()}�." + 
            $"\n{hotDogNum2.Name}{sweetOnionDogNum2.Name}({sweetOnionDogNum2.GetWeight()}�) - {sweetOnionDogNum2.GetCost()}�.");

        Debug.Log($"{hotDogNum3.Name}({hotDogNum3.GetWeight()}�) - {hotDogNum3.GetCost()}�. " + 
            $"\n�������������� ����������:" + 
            $"\n{hotDogNum3.Name}{pickledDogNum3.Name}({pickledDogNum3.GetWeight()}�) - {pickledDogNum3.GetCost()}�." + 
            $"\n{hotDogNum3.Name}{sweetOnionDogNum3.Name}({sweetOnionDogNum3.GetWeight()}�) - {sweetOnionDogNum3.GetCost()}�.");
    }
}
