using UnityEngine;
using UnityEngine.UIElements;

// 修改图片大小
/*
 * position:相对于世界原点
 * local ：相对于父节点的pivot
 * anchored Position：相对于自身anchor的位置
 * transform.width, transform.height,
 * transform.sizedelta：当前UI元素对角线向量和anchor对角线
 *  计算公式
 *      offsetMax = ui矩形右上角坐标 - 锚点矩形右上角坐标
        offsetMin = ui矩形左下角坐标 - 锚点矩形左下角坐标
        sizeDelta = offsetMax - offsetMin;
 * recttransform.rect
 * recttransform.offsetmax, recttransform.offsetmin
 * transform.scale(在世界坐标下的缩放， 相对于原始大小), transform.localscale(在父节点基础上的缩放)
*/

public class ModifyImageRect : MonoBehaviour
{
    private Image _image;

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = transform.GetComponent<RectTransform>();
        var panel = transform.parent as RectTransform;
        panel.sizeDelta = new Vector2(624, 296);
       rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x / 2, rectTransform.sizeDelta.y / 2);
    }

    //pivot、anchor 不一样 怎么正确设置UI的大小（只有sizedelta是可以修改的， rect是只读的）
    // Anchors 汇聚于中心
    private void SetSize1()
    {
        rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        rectTransform.pivot = new Vector2(0.5f, 0.5f);
        
        rectTransform.sizeDelta = new Vector2(11, 8);
        rectTransform.anchoredPosition = new Vector2(2, 3);
    }
    
    // Anchors 汇聚于顶部中心
    private void SetSize2()
    {
        rectTransform.anchorMin = new Vector2(0.5f, 1);
        rectTransform.anchorMax = new Vector2(0.5f, 1); // 设置anchor时 会保持坐标数值不变， UI元素的位置会变
        rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 2, 100);//RectTransform.Edge.Top为父节点的上边，inset是内嵌距离，size是在内嵌方向上的大小，同时设置anchorPosition、， 此方法无需考虑anchor位置
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 300);// 根据当前anchor生成指定大小， 并且父节点改变子节点也会改变【即保持自动布局】
        // rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 200);// 保持自动布局
        rectTransform.anchoredPosition = new Vector2(3, rectTransform.anchoredPosition.y);
        //rectTransform.sizeDelta = new Vector2(300, 100);

    }
    
    //Anchor 分散于四角
    private void Anchor4()
    {
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(1, 1);
        rectTransform.offsetMin = new Vector2(4, 5);
        rectTransform.offsetMax = new Vector2(-2, -3);
    }
}
