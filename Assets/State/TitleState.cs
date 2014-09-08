using UnityEngine;
using Assets.Code.Interfaces;
 
namespace Assets.Code.States {
 public class TitleState : FMS { // MonoBehaviorではなく、上記で宣言したIState
  // StateManagerのインスタンスを再利用できるよう準備
  private StateManager manager;
		
 
  public TitleState(StateManager stateManager) { //ここにエラーがあります。コンストラクタに戻り値？
   //初期化
   manager = stateManager;
  }
 
  public void StateUpdate() { //エラー
   //更新処理
   if(Input.GetKeyUp(KeyCode.Return)) { // Returnキーを押すとBeginStateに遷移
    Application.LoadLevel("Scene2");//シーン0に移る
    Debug.Log("Play State");
    manager.SwitchState(new RenderState(manager));
   }
  }
 
  public void Render() { //エラー
   //描画等
  }
 }
 
}