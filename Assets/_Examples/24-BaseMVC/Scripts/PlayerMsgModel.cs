using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnValueChange(int value);

public class PlayerMsgModel
{

    public OnValueChange onLevelChange;
    public OnValueChange onExperienceChange;
    public OnValueChange onFullExperienceChange;
    public OnValueChange onCoinChange;

    public static PlayerMsgModel PlayerModel {
        get {
            if (_PlayerModel == null) {
                _PlayerModel = new PlayerMsgModel();
            }
            return _PlayerModel;
        }
    }
    private static PlayerMsgModel _PlayerModel;


    private PlayerMsgModel() {

    }

    public int Level {
        get {
            return _Level;
        }
        set {
            _Level = value;
            //if (onLevelChange != null) {
            //    onLevelChange(value);
            //}
            onLevelChange?.Invoke(value);
        }
    }

    public int Experience
    {
        get
        {
            return _Experience;
        }
        set
        {
            //Debug.Assert(_Experience<20,"_Exprienece的值为： "+_Experience);
            _Experience = value;
            //if (onExperienceChange != null)
            //{
            //    onExperienceChange(value);
            //}
            onExperienceChange?.Invoke(value);
        }
    }

    public int FullExperience
    {
        get
        {
            return _FullExperience;
        }
        set
        {
            _FullExperience = value;
            //if (onFullExperienceChange != null)
            //{
            //    onFullExperienceChange(value);
            //}
            onFullExperienceChange?.Invoke(value);
        }
    }

    public int CoinNum
    {
        get
        {
            return _CoinNum;
        }
        set
        {
            _CoinNum = value;
            //if (onCoinChange != null)
            //{
            //    onCoinChange(value);
            //}
            onCoinChange?.Invoke(value);
        }
    }

    private int _Level;
    private int _Experience;
    private int _FullExperience;
    private int _CoinNum;
}
