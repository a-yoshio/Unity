using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Presenter : MonoBehaviour
{
    private bool isCalledOnce = false;
    void Start()
    {
        string x = "yoshio";
        // 保存
        PlayerPrefs.SetString("name", x);
        PlayerPrefs.Save();
        // もし、classや配列を保存したい場合はjson化する
        

    }

    void Update()
    {
        // 一回だけ呼ぶ
        if (!isCalledOnce)
        {
            // 保存したデータをロードする
            string playerName = PlayerPrefs.GetString("name");
            Debug.Log(playerName);
            isCalledOnce = true;
        }
    }
}
