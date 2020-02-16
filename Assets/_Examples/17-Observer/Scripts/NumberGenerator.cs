using System.Collections;
using System;
using System.Collections.Generic;

public abstract class NumberGenerator
{
    public List<Observer> observers=new List<Observer>();
    protected int num;
    public abstract void Generate();
    public void AddObserver(Observer observer){
        observers.Add(observer);
    }
    public void RemoveObserver(Observer observer){
        observers.Remove(observer);
    }
    public int GetNum(){
        return num;
    }
    public abstract void Notity();
}

public class RandomNumberGenerator : NumberGenerator
{
    public override void Generate(){
        Random random=new Random();
        for(int i=0;i<10;i++){
            num=random.Next(0,30);
            Notity();
        }
    }

    public override void Notity(){
        for(int i=0;i<observers.Count;i++){
            observers[i].Update(this);
        }
    }
}
