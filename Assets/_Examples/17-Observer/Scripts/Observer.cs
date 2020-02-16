using UnityEngine;
using System.Text;
using System.Threading;

public interface Observer
{
    void Update(NumberGenerator generator);
}

public class DigitObserver : Observer
{
    public void Update(NumberGenerator generator){
        DebugHelper.Log("DigitObserver",Color.red);
        DebugHelper.Log(generator.GetNum(),Color.red);
        try{
            Thread.Sleep(100);
        }catch(ThreadInterruptedException e){}
    }
}

public class GraphObserver : Observer
{
    public void Update(NumberGenerator generator){
        
        DebugHelper.Log("GraphObserver",Color.green);
        StringBuilder graph=new StringBuilder();
        for(int i=0;i<generator.GetNum();i++){
            graph.Append("*");
        }
        DebugHelper.Log(graph,Color.green);
        try{
            Thread.Sleep(100);
        }catch(ThreadInterruptedException e){}
    }
}
