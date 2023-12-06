using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : ABaseEnemy
{
    private readonly int _id;
    public Enemy3(Animator animator, string attackName)
    {
        _id = Animator.StringToHash(attackName);
        Animator = animator;
    }
    public override void AttackAnimator()
    {
        Animator.SetTrigger(_id);
    }
}
