using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    public int hp;
    public int at;

    // 攻撃する
    public void Attack(EnemyManager enemy) {
        enemy.Damage(at);
    }

    //　ダメージを受ける
    public void Damage(int damege) {
        hp -= damege;
        if (hp <= 0)
        {
            hp = 0;
        }
    }
}
