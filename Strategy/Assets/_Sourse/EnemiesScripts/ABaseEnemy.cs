using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ABaseEnemy
{
    public Animator Animator { get; set; }
    public abstract void AttackAnimator();
}
