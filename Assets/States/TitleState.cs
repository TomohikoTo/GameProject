using UnityEngine;
using Assets.Code.Interfaces;
 
namespace Assets.Code.States {
 public class TitleState : FMS { 
  
  private SM manager;
		
 
  public TitleState(SM SM) { 
   //初期化
   manager = SM;
  }
 
  public void StateUpdate() { 
   //更新処理
   if(Input.GetKeyUp(KeyCode.Return)) { // Returnキーを押すと遷移
    Application.LoadLevel("Scene2");//シーン0に移る
    Debug.Log("Play State");
  //  manager.SwitchState(new RenderState(manager));
   }
  }
 
  public void Render() { //エラー
   //描画等
  }
 }
 
}