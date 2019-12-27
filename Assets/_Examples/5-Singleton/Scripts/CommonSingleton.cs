using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//单例模式的案例
//懒汉模式
public class CommonSingletonV1
{
    private static CommonSingletonV1 instance;
    public static CommonSingletonV1 GetInstance(){
        if(instance==null){
            instance=new CommonSingletonV1();
        }
        return instance;
    }
}
//恶汉模式
public class CommonSingletonV2
{
    private static CommonSingletonV2 instance=new CommonSingletonV2();
    public static CommonSingletonV2 GetInstance(){
        return instance;
    }
}
