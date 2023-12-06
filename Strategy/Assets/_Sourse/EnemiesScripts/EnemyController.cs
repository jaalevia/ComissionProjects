using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Enemy1 Enemy1 { get; set; }
    public Enemy2 Enemy2 { get; set; } 
    public Enemy3 Enemy3 { get; set; }

    public EnemyController(Enemy1 enemy1, Enemy2 enemy2, Enemy3 enemy3)
    { 
        Enemy1 = enemy1;
        Enemy2 = enemy2;
        Enemy3 = enemy3;
    }

    public void EnemySpawn(ABaseEnemy enemy)
    {
        EnemyDespawn();
        enemy.Animator.gameObject.SetActive(true);
            if (enemy != Enemy3)
            {
                enemy.AttackAnimator();
            }
    }

    public void EnemyDespawn()
    { 
        Enemy1.Animator.gameObject.SetActive(false);
        Enemy2.Animator.gameObject.SetActive(false);
        Enemy3.Animator.gameObject.SetActive(false);
    }
}
