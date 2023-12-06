using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : ABaseEnemy
{
    private readonly int _id;
    private GameObject _arrowGameObject;
    private Transform _arrowTransform;
    private float _takeArrow;
    private float _takeArrowTime;

    public Enemy2(Animator animator, string attackName, GameObject arrowGameObject, Transform arrowTransform, float takeArrow)
    {
        _id = Animator.StringToHash(attackName);
        Animator = animator;
        _arrowGameObject = arrowGameObject;
        _arrowTransform = arrowTransform;
        _takeArrowTime = takeArrow;
    }

    public override void AttackAnimator()
    {
        if (_takeArrow <= 0)
        {
            Animator.SetTrigger(_id);
            GameObject.Instantiate(_arrowGameObject, _arrowTransform.position, Quaternion.identity);
            _takeArrow = _takeArrowTime;
        }
        _takeArrow -= Time.deltaTime;
    }
}
