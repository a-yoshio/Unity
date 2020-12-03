using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Presenter : MonoBehaviour
{
    private bool isCalledOnce = false;
    private string jsonPlayer;
    void Start()
    {
        // Player の生成
        PlayerModel player = new PlayerModel();
        jsonPlayer = JsonUtility.ToJson(player);
        Debug.Log("Create player" + jsonPlayer);
    }

    void Update()
    {
        if (!isCalledOnce) {
            // Playerの復元
            PlayerModel player = JsonUtility.FromJson<PlayerModel>(jsonPlayer);
            Debug.Log("Restore Player" + player);
            isCalledOnce = true;
        }

    }
}

[SerializeField]
public class PlayerModel
{
    [SerializeField]
    int hp;
    [SerializeField]
    int at;
    [SerializeField]
    int currentStage;
}