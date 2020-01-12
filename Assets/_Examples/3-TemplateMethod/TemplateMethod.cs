using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateMethod:MonoBehaviour
{
    private void Start() {
        ObjDisplay cube=new CubeDisplay();
        cube.DisplayObj();
        ObjDisplay sphere=new SphereDisplay();
        sphere.DisplayObj();
    }
}
