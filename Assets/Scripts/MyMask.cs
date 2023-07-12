using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * 本次学习内容：MaskableGraphic, RectMask2D, Mask
 *      继承了MaskableGraphic的类可以被裁减 实现了Iclipper(可被裁剪), IMaskble（可被遮罩）
 *      RectMask2D：实现原理：求矩形相交，在fragment shader中设置Alpha = 0， 也就是说会渲染透明物体，造成overdraw， 潜在问题：如果没有使用默认的shader， 需要在自己的shader中设置Alpha
 *      Mask：实现原理是Stencil Test， 注意Mask组件的GameOject的Alpha不能太小，否则会出现Stencil Test通过但是Alpha Test不通过
 * 拓展学习内容
 *  1.回调OnValidate、OnRectTransformDimensionsChange、OnTransformParentChanged、OnHierarchyChange
 *  2.mask 制作圆形遮罩
 *  
 */

public class MyMask : MaskableGraphic
{
    // Start is called before the first frame update
     //private RectMask2D
    // private Mask
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
