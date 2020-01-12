using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AbstractFactory factory=new IDCardFactory();
        AbstractProduct card1=factory.Create("小明");
        AbstractProduct card2=factory.Create("小红");
        AbstractProduct card3=factory.Create("小强");
        card1.Use();
        card2.Use();
        card3.Use();
    }

}
