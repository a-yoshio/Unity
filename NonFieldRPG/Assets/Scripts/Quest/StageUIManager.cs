﻿using System.Collections;
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

    private void Start() {
        stageClearText.SetActive(false);
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
        nextButton.SetActive(false);
        returnButton.SetActive(true);
    }

}
