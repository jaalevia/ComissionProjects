using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Bootstraper : MonoBehaviour
{
    [Header("Animator")]
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private Animator _enemy1Animator;
    [SerializeField] private Animator _enemy2Animator;
    [SerializeField] private Animator _enemy3Animator;

    [Header("Buttons")]
    [SerializeField] private Button _attack1Button;
    [SerializeField] private Button _attack2Button;
    [SerializeField] private Button _attack3Button;

    [Header("Arrow")]
    [SerializeField] private GameObject _arrowGameObject;
    [SerializeField] private Transform _arrowTransform;
    [SerializeField] private float _takeArrow;

    [Header("Controller")]
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private EnemyController _enemyController;

    [SerializeField] private Color _highlightColor;

    void Start()
    {
        _playerController = new PlayerController(_playerAnimator);
        _enemyController = new EnemyController(new Enemy1(_enemy1Animator, "Attack"), new Enemy2(_enemy2Animator, "Attack", _arrowGameObject, _arrowTransform, _takeArrow), new Enemy3(_enemy3Animator, "Attack"));
        new AttackPerformer(_playerController, _enemyController, _attack1Button, _attack2Button, _attack3Button, _highlightColor);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _playerController.PerformAttack();
            _enemyController.Enemy3.AttackAnimator();
        }
        if (_enemyController.Enemy2.Animator.gameObject.activeSelf == true)
        {
            _enemyController.Enemy2.AttackAnimator();
        }
    }
}
