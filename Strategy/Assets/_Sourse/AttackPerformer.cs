using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AttackPerformer
{
    private Button _attack1Button;
    private Button _attack2Button;
    private Button _attack3Button;

    private PlayerController _playerController;
    private EnemyController _enemyController;

    private Color _highlightColor;
    public AttackPerformer(PlayerController playerController, EnemyController enemyController, Button attack1Button, Button attack2Button, Button attack3Button, Color highlightColor)
    { 
        _playerController = playerController;
        _enemyController = enemyController;

        _attack1Button = attack1Button;
        _attack2Button = attack2Button;
        _attack3Button = attack3Button;

        _highlightColor = highlightColor;

        BindButtons();
    }

    private void SetAttack(IAttackStrategy attack, Button currentButton, ABaseEnemy enemyType)
    {
        Clear();
        currentButton.image.color = _highlightColor;
        _playerController.SetStrategy(attack);
        _enemyController.EnemySpawn(enemyType);
    }

    private void Clear() 
    {
        _attack1Button.image.color = Color.white;
        _attack2Button.image.color = Color.white;
        _attack3Button.image.color = Color.white;
    }

    private void BindButtons()
    {
        _attack1Button.onClick.AddListener(() => SetAttack(new Attack1("Attack1"), _attack1Button, _enemyController.Enemy1));
        _attack2Button.onClick.AddListener(() => SetAttack(new Attack2("Attack2"), _attack2Button, _enemyController.Enemy2));
        _attack3Button.onClick.AddListener(() => SetAttack(new Attack3("Attack3"), _attack3Button, _enemyController.Enemy3));
        _attack1Button.onClick.Invoke();
    }
}
