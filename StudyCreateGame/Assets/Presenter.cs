using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Presenter : MonoBehaviour
{
    [SerializeField] GameObject imagePrefab;
    [SerializeField] Transform parent;
    void Start()
    {
        // オブジェクトの生成
        GameObject image = Instantiate(imagePrefab);

        // 親要素の変更
        image.transform.SetParent(parent, false);
    }
}
