using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DigitObserver observer=new DigitObserver();
        GraphObserver observer1=new GraphObserver();
        RandomNumberGenerator generator=new RandomNumberGenerator();
        generator.AddObserver(observer);
        generator.AddObserver(observer1);
        generator.Generate();
    }

}
