using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;
 
public class StateManager : MonoBehaviour
{
 // 現在のゲームの状態を保
	[HideInInspector]
//public GameData gameData;
 private FMS activeState;
 // Singletons
 public static StateManager instance;
 
 void Awake()
 {
  // ゲームの開始画面のSceneがロード(Application.LoadLevel("Scene0"))されるときに、StateManagerと
  // 紐付けされたGameObjectが生成されます。
  // 状態が遷移する際に新たな（別の）Sceneをロード(Application.LoadLevel("Scene1"))します。その際に
  // 今まであったGameObjectは除去されます。開始シーンがロードされ
  // るたびにStateManagerやGameManagerが生成されないために、
  // インスタンスが常に一つだけあるようにします。
  if(instance == null) {
   instance = this;
   DontDestroyOnLoad(gameObject);
  } else {
   DestroyImmediate(gameObject);
  }
 
 }
 
 void OnGUI()
 {
   activeState.Render();
 }
 
 void Start()
  {
    activeState = new TitleState(this);
  //  gameData = GetComponent<GameData> ();
  }
 void Update()
 {
  if(activeState != null)
   activeState.StateUpdate();
 }
 public void SwitchState(FMS newState) 
 {
  activeState = newState;
 }
}