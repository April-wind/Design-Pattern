using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToolController : MonoBehaviour {
    public BaseCommand _currentBasecommand;
    public Transform currentTran;
    public ToggleGroup _toggleGroup;
    public Toggle[] _toggles;

    void Start () {
        foreach (var item in _toggles) {
            item.onValueChanged.AddListener ((ison) => {
                _currentBasecommand = ison?item.GetComponent<ToolConfig> ().command : null;
            });
        }
    }
    void Update () {
        if (_currentBasecommand!=null){
			
            _currentBasecommand.Execute(currentTran);
        }
    }

}