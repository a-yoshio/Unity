using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIManager : MonoBehaviour
{
    public Text hpText;
    public Text atText;

    public void SetupUI(PlayerManger player) {
        hpText.text = string.Format("HP: {0}", player.hp);
        atText.text = string.Format("AT: {0}", player.at);
    }

    public void UpdateUI(PlayerManger player) {
        hpText.text = string.Format("HP:{0}", player.hp);
    }
}
