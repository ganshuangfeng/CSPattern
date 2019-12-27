using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class UIEvent : MonoBehaviour
{
    public Button button;
    private List<Type> mgrList=new List<Type>();
    private int index=0;
    // Start is called before the first frame update
    void Start()
    {
        if(button!=null){
            button.onClick.AddListener(OnBtnClick);
        }
        mgrList.Add(typeof(TestMgr1));
        mgrList.Add(typeof(TestMgr2));
        mgrList.Add(typeof(TestMgr3));
        mgrList.Add(typeof(TestMgr4));
        mgrList.Add(typeof(TestMgr5));
        mgrList.Add(typeof(TestMgr6));
    }

    private void OnBtnClick(){
        Type type=mgrList[index];
        string typeName=type.Name;
        Type instanceType;
        switch(typeName){
            case "TestMgr1":
                instanceType=TestMgr1.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.red);
            break;
            case "TestMgr2":
                instanceType=TestMgr2.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.green);
            break;
            case "TestMgr3":
                instanceType=TestMgr3.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.blue);
            break;
            case "TestMgr4":
                instanceType=TestMgr4.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.red);
            break;
            case "TestMgr5":
                instanceType=TestMgr5.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.green);
            break;
            case "TestMgr6":
                instanceType=TestMgr6.GetInstance().GetType();
                DebugHelper.Log("Create Instance "+instanceType.Name,Color.blue);
            break;
            default:
            break;
        }
        index++;
        if(index>=mgrList.Count){
            index=0;
        }
    }
}
