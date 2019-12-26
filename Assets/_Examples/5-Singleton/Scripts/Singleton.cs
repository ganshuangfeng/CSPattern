using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Singleton<T> :MonoBehaviour where T:MonoBehaviour{
    public static T Instance;
    private static Singleton<T> singleT=new Singleton<T>();
    public Singleton(){
        GameObject obj=new GameObject(typeof(T).Name);
        Instance=obj.GetComponent<T>();
    }
    public static T GetInstance(){
        return Instance;
    }
}
