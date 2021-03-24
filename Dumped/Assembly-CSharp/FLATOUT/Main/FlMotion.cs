/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main.Utility;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlMotion : FlBase
	{
		// Fields
		private Hashtable _childGameObjectTable;
		private FlMotionParameter _parameter;
		private List<FlObjectBase> _objectList;
		private FlObject _parentObject;
		private bool _existParentObject;
		private ResetModeTypes _resetModeType;
		private StateTypes _currentStateType;
		public string _currentLabelName;
		public int _currentLabelIndex;
		public Vector2 _currentLabelTimeRange;
		public string _nextLabelName;
		public int _nextLabelIndex;
		public Action _labelActionStart;
		public Action _labelActionLoop;
		public Action _labelActionEnd;
		public bool _existLabelActionStart;
		public bool _existLabelActionLoop;
		public bool _existLabelActionEnd;
		public FlAction _labelFlActionStart;
		public FlAction _labelFlActionLoop;
		public FlAction _labelFlActionEnd;
		public bool _existLabelFlActionStart;
		public bool _existLabelFlActionLoop;
		public bool _existLabelFlActionEnd;
		public float _currentTime;
		public float _prevTime;
		public float _objectTime;
		public float _objectTimeWithoutLastFrame;
		public float _fixObjectTime;
		private float _restCurrentTime;
		private bool _updateLowerFlag;
		private MeshRenderer[] _meshRenderList;
		private Collider[] _colliderList;
		private Collider2D[] _collider2DList;
		private Transform[] _tempTransformList;
		private List<FlBase> _tempChildBaseList;
		private FlBase[] _childBaseList;
		private bool _existStencilRefCountUp;
		private FlUguiGraphic[] _uGuiGraphicList;
		private bool _uGuiGraphicChecked;
	
		// Properties
		public FlMotionParameter Parameter { get; }
		public FlObject ParentObject { get; }
		public bool ExistParentObject { get; }
		public string CurrentLabelName { get; set; }
		public int CurrentLabelIndex { get; set; }
		public Vector2 CurrentLabelTimeRange { get; set; }
		public float CurrentLabelTimeLength { get; }
		public float CurrentLabelTime { get; }
		public int CurrentLabelFrame { get; }
		public float CurrentLabelNormalizeTime { get; }
		public string NextLabelName { get; set; }
		public int NextLabelIndex { get; set; }
		public Action LabelActionStart { get; set; }
		public Action LabelActionLoop { get; set; }
		public Action LabelActionEnd { get; set; }
		public bool ExistLabelActionStart { get; set; }
		public bool ExistLabelActionLoop { get; set; }
		public bool ExistLabelActionEnd { get; set; }
		public ResetModeTypes ResetModeType { get; }
		public StateTypes CurrentState { get; }
		public float CurrentTime { get; set; }
		public float PrevTime { get; }
		public float ObjectTime { get; }
		public float ObjectTimeWithoutLastFrame { get; }
		public float FixObjectTime { get; }
		public float MotionSpeed { get; }
		public bool ExistStencilRefCountUp { get; set; }
		public List<FlObjectBase> ObjectList { get; }
	
		// Nested types
		public enum ResetModeTypes
		{
			ResetAll = 0,
			None = 1,
			ResetLabel = 2
		}
	
		public enum StateTypes
		{
			Playing = 0,
			Pause = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<FlObjectBase> __9__115_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int __FixData_b__115_0(FlObjectBase a, FlObjectBase b);
		}
	
		// Constructors
		public FlMotion(GameObject gameObject);
	
		// Methods
		public void _CreateEditorData(FlMotionParameter parameter, FlObject parentObject, FlRoot root);
		public void _ApplyData(FlMotionParameter parameter, FlObject parentObject, FlRoot root);
		public override void _CreateData();
		public override void _FixData();
		public GameObject _GetChildGameObject(string gameObjectName);
		private void _CreateChildGameObjectTable();
		public override void _UpdateFirst();
		public override void _UpdateSecond();
		private void _UpdateVisible();
		private void _UpdateColor();
		private void _UpdateState();
		private void _UpdateTime();
		private void _UpdateBlurValue();
		private void _UpdateChildren();
		public override void _ResetTime();
		public void SetResetModeType(ResetModeTypes resetModeType);
		public void SetMotionPlay();
		public void SetMotionPlay(string labelName);
		public void SetMotionPlay(string labelName, float timeOffset);
		public void SetMotionPlay(string labelName, int frameOffset);
		public void SetMotionPlay(float time);
		public void SetMotionPlay(int frame);
		public void SetMotionPause();
		public void SetMotionPause(string labelName);
		public void SetMotionPause(string labelName, float timeOffset);
		public void SetMotionPause(string labelName, int frameOffset);
		public void SetMotionPause(float time);
		public void SetMotionPause(int frame);
		public void SetMotionReset();
		public void SetMotionStop();
		private void _SetMotionPlayBase(float time, bool pause);
		private void _CheckLowerObjects();
		private void _UpdateLowerObjects(bool visible);
		private void _UpdateChildVisible(bool visible);
		private void _UpdateEnableRenderer(bool enable);
		private void _UpdateEnableCollider(bool enable);
		protected override void _UpdateSortOrder();
		protected override void _UpdateSortLayer();
		public override void _UpdateStencilRef(bool affectChildren);
		protected override void _SetGrayscaleBase(bool enable);
		public void SetAction(string labelName, Action action, FlMotionActionTypes actionType);
		public void AddAction(string labelName, FlMotionActionTypes actionType, Action<object> action, object value, int id = -1);
		public void RemoveAllAction(string labelName, FlMotionActionTypes actionType);
		public void RemoveAllAction();
		public void RemoveActionFromID(string labelName, FlMotionActionTypes actionType, int id);
		public void RemoveActionFromIndex(string labelName, FlMotionActionTypes actionType, int index);
		private void _AddActionBase(Hashtable targetTable, Action<object> action, object value, int id = -1);
		private void _RemoveActionBase(Hashtable targetTable, int id = -1, int index = -1);
		public override void SetSortOffset(int sortOffset);
		public override void SetSortLayer(string sortLayerName);
		public override void SetTimeModeType(FlTimeModeTypes timeModeType, bool children);
		public override void SetMotionSpeed(float speed, bool children);
		public override void SetColliderThrough(bool through, bool affectChildren);
		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren);
		public override void _UpdateColliderThickness(bool affectChildren);
		public override void SetEnableCollider(bool enable, bool affectChildren);
		public override void SetSubCollider(Collider subCollider, bool affectChildren);
		public override void SetBlurQuality(int blurRadius, int blurQuality, bool affectChildren);
		public override void SetBlurValue(Vector2 blurValue, bool affectChildren);
	}
}
