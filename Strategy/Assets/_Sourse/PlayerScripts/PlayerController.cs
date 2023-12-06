using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
    private Animator _playerAnimator;
    private IAttackStrategy _strategy;

    public PlayerController(Animator playerAnimator)
    {
        _playerAnimator = playerAnimator;
    }
    public void SetStrategy(IAttackStrategy strategy) 
    { 
        _strategy= strategy;
    }

    public void PerformAttack()
    {
        
        _strategy.AttackAnimator(_playerAnimator);
    }
}
