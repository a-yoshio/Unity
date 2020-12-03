using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Attack : MonoBehaviour
{
    [SerializeField] GameObject blockImage;
    [SerializeField] GameObject attackImage;
    [SerializeField] Text pointText;
    public void onClickButton()
    {
        Debug.Log("発射！");
        // 攻撃側のObjectを動かす
        float position = attackImage.transform.position.y;
        while (attackImage.transform.position.y < blockImage.transform.position.y)
        {
            Debug.Log(attackImage.transform.position.y);
            position += 20;
            attackImage.transform.Translate(0, position, 0);
        }
        // 相手側のObjectを非表示
        // 1. 隠す↓
        // image.SetActive(false);
        // 2. 破壊↓
        Destroy(blockImage);
        // ポイント追加
        int current = int.Parse(pointText.text);
        int newPoint = current + 10;
        pointText.text = newPoint.ToString();
    }

}