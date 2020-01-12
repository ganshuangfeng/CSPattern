using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class ObjDisplay
{

    public abstract void Create();
    public abstract void Destroy();
    public abstract void TransformObj();
    public void DisplayObj(){
        Create();
        TransformObj();
        Destroy();
    }
}

public class CubeDisplay:ObjDisplay{
    public override void Create(){
        DebugHelper.Log("create one cube");
    }
    public override void Destroy(){
        DebugHelper.Log("destroy one cube");
    }
    public override void TransformObj(){
        DebugHelper.Log("rotate the cube....");
    }
}

public class SphereDisplay:ObjDisplay{
    public override void Create(){
        DebugHelper.Log("create one sphere");
    }
    public override void Destroy(){
        DebugHelper.Log("destroy one sphere");
    }
    public override void TransformObj(){
        DebugHelper.Log("scale the sphere....");
    }
}
