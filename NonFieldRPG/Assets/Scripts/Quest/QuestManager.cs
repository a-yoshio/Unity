using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// クエスト全体を管理
public class QuestManager : MonoBehaviour
{
    public StageUIManager stageUI;
    public GameObject enemyPrefab;
    public BattleManager battleManeger;
    public SceneTransition sceneTransition;
    // 敵に遭遇するテーブル：-1なら遭遇しない、０なら遭遇
    int[] encountTable = { -1, -1, 0, -1, 0, -1 };
    int currentStage = 0; // 現在のステージ進行度
    private void Starg() {
        stageUI.UpdateUI(currentStage);
    }
    
    // 進行度を増加する
    public void onNextButton() {
        currentStage++;
        // 進行度をUIに反映
        stageUI.UpdateUI(currentStage);
        if (encountTable.Length <= currentStage) {
            Debug.Log("クエストクリア");
            QuestClear();
        } else if (encountTable[currentStage] == 0) {
            Debug.Log("敵に遭遇");
            EncountEnemy();
        }
    }

    void EncountEnemy() {
        stageUI.ShowButton(false);
        GameObject enemyObj = Instantiate(enemyPrefab);
        EnemyManager enemy = enemyObj.GetComponent<EnemyManager>();
        battleManeger.Setup(enemy);
    }

    public void EndButtle() {
        stageUI.ShowButton(true);
    }

    void QuestClear() {
        // クエストクリア！と表示する
        // 街に戻るボタンを表示する
        stageUI.ShowClearText();
    }
}
