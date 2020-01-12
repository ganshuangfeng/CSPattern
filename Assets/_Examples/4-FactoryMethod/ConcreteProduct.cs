using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IDCard:AbstractProduct
{
    private string owner;
    public IDCard(string owner){
        DebugHelper.Log("make "+owner+" ID card\n");
        this.owner=owner;
    }
    public override void Use(){
        DebugHelper.Log("use "+owner+" ID card\n");
    }
    public string GetOwner(){
        return  owner;
    }
}
