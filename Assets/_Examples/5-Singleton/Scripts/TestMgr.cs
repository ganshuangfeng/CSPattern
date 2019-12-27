using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//每一个单例作为一个独立的游戏对象
public class TestMgr1 : Singleton<TestMgr1>
{
}
public class TestMgr2 : Singleton<TestMgr2>
{
}

public class TestMgr3 : Singleton<TestMgr3>
{
}

//所有单例放置到GameMgr下
public class TestMgr4 : SingletonV2<TestMgr4>
{
}
public class TestMgr5 : SingletonV2<TestMgr5>
{
}

public class TestMgr6 : SingletonV2<TestMgr6>
{
}
