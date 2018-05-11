using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM02Bridge : MonoBehaviour {

    void Start()
    {
        IRenderEngine render = new DirectX();
        Sphere sphere = new Sphere(render);
        sphere.Draw();

        Cube cube = new Cube(render);
        cube.Draw();

        Capsule capsule = new Capsule(render);
        capsule.Draw();


    }

}

public class IShape
{
    public string name;
    public IRenderEngine renderEngine;

    public IShape(IRenderEngine renderEngine) { this.renderEngine = renderEngine; }
    public void Draw() { renderEngine.Draw(name); }
}

public abstract class IRenderEngine
{
    public virtual void Draw(string name) { }
}

public class Sphere:IShape
{
    public Sphere(IRenderEngine render) :base(render){ name = "Sphere";}
}

public class Cube:IShape
{
    public Cube(IRenderEngine render) : base(render) { name = "Cube"; }
}

public class Capsule:IShape
{
    public Capsule(IRenderEngine render) : base(render) { name = "Capsule"; }
}



public class OpenGL:IRenderEngine
{
    public override void Draw(string name)
    {
        Debug.Log("OpenGL render done ... " + name);
    }
}

public class DirectX:IRenderEngine
{
    public override void Draw(string name)
    {
        Debug.Log("DirectX render done ... " + name);
    }
}
