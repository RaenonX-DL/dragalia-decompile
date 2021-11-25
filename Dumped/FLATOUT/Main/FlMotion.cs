using System;
using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main.Utility;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlMotion : FlBase
	{
		public enum ResetModeTypes
		{
			ResetAll,
			None,
			ResetLabel
		}

		public enum StateTypes
		{
			Playing,
			Pause
		}

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

		public FlMotionParameter Parameter => null;

		public FlObject ParentObject => null;

		public bool ExistParentObject => default(bool);

		public string CurrentLabelName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int CurrentLabelIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Vector2 CurrentLabelTimeRange
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float CurrentLabelTimeLength => default(float);

		public float CurrentLabelTime => default(float);

		public int CurrentLabelFrame => default(int);

		public float CurrentLabelNormalizeTime => default(float);

		public string NextLabelName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int NextLabelIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Action LabelActionStart
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action LabelActionLoop
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action LabelActionEnd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ExistLabelActionStart
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ExistLabelActionLoop
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ExistLabelActionEnd
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ResetModeTypes ResetModeType => default(ResetModeTypes);

		public StateTypes CurrentState => default(StateTypes);

		public float CurrentTime
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float PrevTime => default(float);

		public float ObjectTime => default(float);

		public float ObjectTimeWithoutLastFrame => default(float);

		public float FixObjectTime => default(float);

		public float MotionSpeed => default(float);

		public bool ExistStencilRefCountUp
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<FlObjectBase> ObjectList => null;

		public FlMotion(GameObject gameObject)
		{
		}

		public void _CreateEditorData(FlMotionParameter parameter, FlObject parentObject, FlRoot root)
		{
		}

		public void _ApplyData(FlMotionParameter parameter, FlObject parentObject, FlRoot root)
		{
		}

		public override void _CreateData()
		{
		}

		public override void _FixData()
		{
		}

		public GameObject _GetChildGameObject(string gameObjectName)
		{
			return null;
		}

		private void _CreateChildGameObjectTable()
		{
		}

		public override void _UpdateFirst()
		{
		}

		public override void _UpdateSecond()
		{
		}

		private void _UpdateVisible()
		{
		}

		private void _UpdateColor()
		{
		}

		private void _UpdateState()
		{
		}

		private void _UpdateTime()
		{
		}

		private void _UpdateBlurValue()
		{
		}

		private void _UpdateChildren()
		{
		}

		public override void _ResetTime()
		{
		}

		public void SetResetModeType(ResetModeTypes resetModeType)
		{
		}

		public void SetMotionPlay()
		{
		}

		public void SetMotionPlay(string labelName)
		{
		}

		public void SetMotionPlay(string labelName, float timeOffset)
		{
		}

		public void SetMotionPlay(string labelName, int frameOffset)
		{
		}

		public void SetMotionPlay(float time)
		{
		}

		public void SetMotionPlay(int frame)
		{
		}

		public void SetMotionPause()
		{
		}

		public void SetMotionPause(string labelName)
		{
		}

		public void SetMotionPause(string labelName, float timeOffset)
		{
		}

		public void SetMotionPause(string labelName, int frameOffset)
		{
		}

		public void SetMotionPause(float time)
		{
		}

		public void SetMotionPause(int frame)
		{
		}

		public void SetMotionReset()
		{
		}

		public void SetMotionStop()
		{
		}

		private void _SetMotionPlayBase(float time, bool pause)
		{
		}

		private void _CheckLowerObjects()
		{
		}

		private void _UpdateLowerObjects(bool visible)
		{
		}

		private void _UpdateChildVisible(bool visible)
		{
		}

		private void _UpdateEnableRenderer(bool enable)
		{
		}

		private void _UpdateEnableCollider(bool enable)
		{
		}

		protected override void _UpdateSortOrder()
		{
		}

		protected override void _UpdateSortLayer()
		{
		}

		public override void _UpdateStencilRef(bool affectChildren)
		{
		}

		protected override void _SetGrayscaleBase(bool enable)
		{
		}

		public void SetAction(string labelName, Action action, FlMotionActionTypes actionType)
		{
		}

		public void AddAction(string labelName, FlMotionActionTypes actionType, Action<object> action, object value, int id = -1)
		{
		}

		public void RemoveAllAction(string labelName, FlMotionActionTypes actionType)
		{
		}

		public void RemoveAllAction()
		{
		}

		public void RemoveActionFromID(string labelName, FlMotionActionTypes actionType, int id)
		{
		}

		public void RemoveActionFromIndex(string labelName, FlMotionActionTypes actionType, int index)
		{
		}

		private void _AddActionBase(Hashtable targetTable, Action<object> action, object value, int id = -1)
		{
		}

		private void _RemoveActionBase(Hashtable targetTable, int id = -1, int index = -1)
		{
		}

		public override void SetSortOffset(int sortOffset)
		{
		}

		public override void SetSortLayer(string sortLayerName)
		{
		}

		public override void SetTimeModeType(FlTimeModeTypes timeModeType, bool children)
		{
		}

		public override void SetMotionSpeed(float speed, bool children)
		{
		}

		public override void SetColliderThrough(bool through, bool affectChildren)
		{
		}

		public override void SetColliderThicknessOffset(float thicknessOffset, bool affectChildren)
		{
		}

		public override void _UpdateColliderThickness(bool affectChildren)
		{
		}

		public override void SetEnableCollider(bool enable, bool affectChildren)
		{
		}

		public override void SetSubCollider(Collider subCollider, bool affectChildren)
		{
		}

		public override void SetBlurQuality(int blurRadius, int blurQuality, bool affectChildren)
		{
		}

		public override void SetBlurValue(Vector2 blurValue, bool affectChildren)
		{
		}
	}
}
