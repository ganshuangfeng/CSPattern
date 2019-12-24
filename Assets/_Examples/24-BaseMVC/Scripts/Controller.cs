using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        
        PlayerMsgModel.PlayerModel.Level = 3;
        PlayerMsgModel.PlayerModel.Experience = 0;
        PlayerMsgModel.PlayerModel.FullExperience = 30;
        PlayerMsgModel.PlayerModel.CoinNum = 3;
    }

    public void OnUpButtonClicked() {
        PlayerMsgModel.PlayerModel.Experience += 10;
        if (PlayerMsgModel.PlayerModel.Experience > PlayerMsgModel.PlayerModel.FullExperience) {
            PlayerMsgModel.PlayerModel.Level += 1;
            PlayerMsgModel.PlayerModel.FullExperience += 50;
            if (PlayerMsgModel.PlayerModel.Level % 3 == 0)
            {
                PlayerMsgModel.PlayerModel.CoinNum += 10;
            }
        }
        
    }
}
