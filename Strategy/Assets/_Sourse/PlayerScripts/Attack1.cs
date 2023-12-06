using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class Attack1 : IAttackStrategy
{
    private readonly int _id;

    public void AttackAnimator(Animator animator)
    {
        animator.SetTrigger(_id);
    }

    public Attack1(string attackName)
    {
       
        _id = Animator.StringToHash(attackName);
    }
}
