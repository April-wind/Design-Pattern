using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ToolConfig : MonoBehaviour {
    public BaseCommand command;
    public CommandType commandType;

    void Start () {
        Type type = Type.GetType (commandType.ToString ());
        if (type != null) {
            var temp = Activator.CreateInstance (type);
            command = temp as BaseCommand;
        }
        else
        {
            Debug.LogError("未找到要实例化的类,请检查类名是否和枚举值相同");
        }
    }
}