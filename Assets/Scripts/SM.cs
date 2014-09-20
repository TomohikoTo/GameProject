using UnityEngine;
using Assets.Code.States;
using Assets.Code.Interfaces;
 
public class SM : MonoBehaviour
{
 
	[HideInInspector]

 private FMS activeState;

 public static SM instance;
 
 void Awake()
 {
 
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
