using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : BaseCommand {

	public override void Execute (Transform t) {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			pos = new Vector3 (pos.x, pos.y, Camera.main.nearClipPlane);
			//Debug.Log(pos);
			t.transform.position = pos;

		}
	}
	/// <summary>
	/// 锤子工具没有边界限制，可以全屏点击
	/// </summary>
	/// <returns></returns>
	public override bool BoundClamp () {
		return true;
	}
}