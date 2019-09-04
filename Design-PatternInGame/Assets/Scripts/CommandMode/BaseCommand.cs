using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCommand {
    /// <summary>
    /// 执行
    /// </summary>
    public abstract void Execute(Transform t);
    /// <summary>
    /// 边界限制
    /// </summary>
    public abstract  bool BoundClamp();
}

//通过枚举来定义命令类型
public enum CommandType
{
    ClickCommand,//锤子工具的命令
    SliderCommand//刷子工具的命令
}