using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public AbstractProduct Create(string owner){
        AbstractProduct product=CreateProduct(owner);
        RegisterProduct(product);
        return product;
    }
    protected abstract AbstractProduct CreateProduct(string owner);
    protected abstract void RegisterProduct(AbstractProduct product);
}
