using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;  
 
public class OpenWeb1 : MonoBehaviour {
    public static Process C;

    public static Process D;

    public static Process E;
    // Use this for initialization
    void Start () {
        
    }
	
    // Update is called once per frame
    void Update () {
		
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 300, 50), "单例模式与静态方法区别"))
        {
            CallWeb(C,"https://blog.csdn.net/yuechuzhao/article/details/46906217");
 
        }
        
        

/*
        if (GUI.Button(new Rect(200, 50, 100, 30), "关闭"))
        {
            //这个地方并不能关闭打开的浏览器，错误显示为：SystemException: No process to kill.
            C.Kill();
        }
        if (GUI.Button(new Rect(200, 100, 100, 30), "关闭"))
        {
            //这个地方并不能关闭打开的浏览器，错误显示为：SystemException: No process to kill.
            D.Kill();
        }
 
*/
    }
    void CallWeb(Process process,string url)
    {
        //可以自己选择浏览器，也可以用系统设置的默认浏览器，默认浏览器就不需要传入："IExplore.exe"这个参数
         process = System.Diagnostics.Process.Start("Chrome.exe", url);  
        //C = System.Diagnostics.Process.Start("https://www.baidu.com/");
    }  
}