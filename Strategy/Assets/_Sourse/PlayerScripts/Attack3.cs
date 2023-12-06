using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack3 : IAttackStrategy
{
    private readonly int _id;
    public void AttackAnimator(Animator animator)
    {
        animator.SetTrigger(_id);
    }
    public Attack3(string attackName)
    {
        _id = Animator.StringToHash(attackName);
    }
}
