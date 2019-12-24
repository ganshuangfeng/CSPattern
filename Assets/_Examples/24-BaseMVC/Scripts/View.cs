using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public UILabel experiencesLabel;
    public UILabel levelLabel;
    public UILabel coinLabel;
    // Start is called before the first frame update
    void Awake()
    {
        PlayerMsgModel.PlayerModel.onLevelChange += SetLevel;
        PlayerMsgModel.PlayerModel.onExperienceChange += SetExperiences;
        PlayerMsgModel.PlayerModel.onFullExperienceChange += SetFullExperiences;
        PlayerMsgModel.PlayerModel.onCoinChange += SetCoin;
    }


    void SetLevel(int value) {
        levelLabel.text = value.ToString();
    }

    void SetExperiences(int value) {

        experiencesLabel.text = value.ToString()+"/"+PlayerMsgModel.PlayerModel.FullExperience;
        
        
    }

    void SetFullExperiences(int value)
    {
        experiencesLabel.text = PlayerMsgModel.PlayerModel.Experience + "/" + value.ToString();
        //Debug.Log(experiencesLabel.text);
    }

    void SetCoin(int value) {
        coinLabel.text = value.ToString();
    }
}
