using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderCommand : BaseCommand {
    private Vector3 offset = Vector3.zero;
    private bool isDown = false;
    public override void Execute (Transform t) {
        if (Input.GetMouseButtonDown (0)) {
            isDown = true;
            var pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            offset = t.transform.position - pos;
            offset = new Vector3 (offset.x, offset.y, 0);			
            if (!ClickClamp (new Vector3 (pos.x, pos.y, pos.z), t)){

                if (!BoundClamp())return;

                t.transform.position=new Vector3(pos.x,pos.y,t.position.z);	
                offset=Vector3.zero;
            }
        }
        if (isDown) {
            if (Input.GetMouseButton (0)) {

                if (!BoundClamp())return;

                var pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
                pos = new Vector3 (pos.x, pos.y, t.transform.position.z);
                t.transform.position = pos + offset;
            }
        }
        if (Input.GetMouseButtonUp(0)){
            isDown=false;
        }
    }
    private bool ClickClamp (Vector3 pos, Transform t) {
        pos = new Vector3 (pos.x, pos.y, Camera.main.nearClipPlane);
        if (t.GetComponent<BoxCollider> ().bounds.Contains (pos)) {
            return true;
        }
        return false;
    }
    /// <summary>
    /// 为刷子添加一些拖动范围的限制，例如，
    /// 限制可拖动范围为距离屏幕边缘上200px、下100px
    /// </summary>
    /// <returns></returns>
    public override bool BoundClamp(){
        var pos=Input.mousePosition;
        //Debug.Log(pos);
        Rect rect=new Rect(200,100,Screen.width-200,Screen.height-100);
        if (pos.x<rect.x||pos.x>rect.width){
            return false;
        }
        if (pos.y<rect.y||pos.y>rect.height){
            return false;
        }
        return true;
    }
}