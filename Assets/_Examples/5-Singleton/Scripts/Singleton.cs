using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
public class Singleton<T> :MonoBehaviour where T:MonoBehaviour{
    private static T instance;
    public static T GetInstance(){
        if(instance==null){
            GameObject obj=new GameObject(typeof(T).Name);
            instance=obj.AddComponent<T>();
        }
        return instance;
    }
}

public class SingletonV2<T> :MonoBehaviour where T:MonoBehaviour{
    private static T instance;
    public static T GetInstance(){
        if(instance==null&&typeof(T).Name.Equals("GameMgr")){
            GameObject obj=new GameObject("GameMgr");
            instance=obj.AddComponent<T>();
        }else if(instance==null){
            instance=GameMgr.GetInstance().gameObject.AddComponent<T>();
        }
        return instance;
    }
}
