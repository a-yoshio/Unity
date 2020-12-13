using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// StageUIを管理（ステージ数のUI/進行ボタン/街に戻るボタン）の管理
public class StageUIManager : MonoBehaviour
{
    public Text stageText;
    public GameObject nextButton;
    public GameObject returnButton;
    public GameObject stageClearText;
    public GameObject treasureBox;

    public GameObject blueCrystal;
    public GameObject redCrystal;
    public GameObject greenCrystal;
    private Dictionary<string, GameObject> rewards;

    private Dictionary<string, GameObject> getRewards() {
        return new Dictionary<string, GameObject> () {
            {"RED", redCrystal},
            {"BLUE", blueCrystal},
            {"GREEN", greenCrystal}
        };
    }
    
    private void randomSelectReward() {
        Dictionary<string, GameObject> rewards = this.getRewards();
        List<string> rewardsKeyList = new List<string>(rewards.Keys);
        int keyNumber = Random.Range(0, rewardsKeyList.Count - 1);
        rewards[rewardsKeyList[keyNumber]].SetActive(true);
    }

    private void Start() {
        stageClearText.SetActive(false);
        treasureBox.SetActive(false);
        foreach (KeyValuePair<string, GameObject> reward in getRewards()) {
            GameObject rewardValue = reward.Value;
            rewardValue.SetActive(false);
        }

    }
    public void UpdateUI(int currentStage) {
        stageText.text = string.Format("ステージ: {0}", currentStage+1);        
    }

    public void ShowButton(bool isTrue) {
        nextButton.SetActive(isTrue);
        returnButton.SetActive(isTrue);
    }

    public void ShowClearText() {
        stageClearText.SetActive(true);
        treasureBox.SetActive(true);
        nextButton.SetActive(false);
        returnButton.SetActive(true);
        this.randomSelectReward();
    }

}
