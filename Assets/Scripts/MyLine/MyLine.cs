using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * LindeRender:适合3D画线
 * UIMeshLine:适合2D画线
 */
public class MyLine : MaskableGraphic, IMeshModifier, ICanvasRaycastFilter
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ModifyMesh(Mesh mesh)
    {
        throw new System.NotImplementedException();
    }

    public void ModifyMesh(VertexHelper verts)
    {
        throw new System.NotImplementedException();
    }

    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        throw new System.NotImplementedException();
    }
}
