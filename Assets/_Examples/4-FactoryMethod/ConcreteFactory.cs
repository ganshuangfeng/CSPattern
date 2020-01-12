using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDCardFactory:AbstractFactory
{
    private List<string> owners=new List<string>();
    protected override AbstractProduct CreateProduct(string owner){
        return new IDCard(owner);
    }

    protected override void RegisterProduct(AbstractProduct product){
        owners.Add(((IDCard)product).GetOwner());
    }
    public List<string> GetOwners(){
        return owners;
    }
}
