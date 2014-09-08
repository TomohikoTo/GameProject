namespace Assets.Code.Interfaces
{
 // IStateを実装したクラスは、IState型として利用・
 // 活用ができるようになります。
 public interface FMS
	
 {
  // UnityのUpdate()メソッドが呼び出します。
  void StateUpdate();
 
  // 描画に使います。
  void Render();
 }
}