using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
        public PlayerUIManager playerUI;
        public EnemyUIManager enemyUI;
        public PlayerManger player;
        public EnemyManager enemy;
        public QuestManager quest;

        void Start() {
            enemyUI.gameObject.SetActive(false);
        }

        public void Setup(EnemyManager enemyManager) {
            enemyUI.gameObject.SetActive(true);
            enemy = enemyManager;
            enemyUI.SetupUI(enemy);
            playerUI.SetupUI(player);

            enemy.AddEventListenerOnTap(PlayerAttack);
        }


        void PlayerAttack() {
            // PlayerがEnemyに攻撃
            player.Attack(enemy);
            enemyUI.UpdateUI(enemy);
            if (enemy.hp <= 0) {
                Destroy(enemy.gameObject);
                EndButtle();
                quest.EndButtle();
                enemyUI.gameObject.SetActive(false);
            } else {
                EnemyTurn();
            }
        }

        void EnemyTurn() {
            //　EnemyがPlayerに攻撃
            enemy.Attack(player);
            playerUI.UpdateUI(player);
        }

        void EndButtle() {
            Debug.Log("Buttle End");
        }
}
