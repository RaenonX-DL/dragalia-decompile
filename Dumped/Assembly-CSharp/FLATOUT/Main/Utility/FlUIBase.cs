/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlUIBase
	{
		// Fields
		protected string _logTitle;
		protected Color _logColor;
		protected bool _exist;
		protected bool _firstUpdateFlag;
		protected bool _updateFlag;
		protected int _currentUpdateDepth;
		protected int _maxUpdateDepth;
		protected bool _enable;
		protected FlUIEnableTypes _enableType;
		protected bool _parentEnable;
		protected bool _isActive;
		protected bool _prevIsActive;
		protected FlUIBaseStateTypes _currentBaseState;
		protected FlComponentBase _component;
		protected FlRoot _root;
		protected GameObject _rootObject;
		protected string _motionPath;
		protected FlMotion _motion;
		protected GameObject _motionObject;
		protected string _hitAreaObjectPath;
		protected FlObjectBase _hitAreaObject;
		protected bool _isHiAreaActive;
		protected Camera _inputCamera;
		protected FlInputTypes _currentInputType;
		protected FlInputBase _currentInput;
		protected FlUIBase _parentUI;
		protected FlInputUpTypes _inputUpType;
		protected bool _forceDownIn;
		protected bool _forceDownLoop;
		protected bool _forceSelectIn;
		protected bool _forceSelectLoop;
		protected bool _forceOverIn;
		protected bool _forceOverLoop;
		protected bool _enableOverInputForMouse;
		protected bool _enableSelectInputForTouchInput;
		protected bool _enableSelectInputForKeyInput;
		protected bool _enableSelectInputForRayInput;
		protected bool _enableDownInputForTouchInput;
		protected bool _enableDownInputForKeyInput;
		protected bool _enableDownInputForRayInput;
		protected bool _enableDownLoopForTouchInput;
		protected bool _enableDownLoopForKeyInput;
		protected bool _enableDownLoopForRayInput;
		protected bool _enableContinuousInputForTouchInput;
		protected bool _enableContinuousInputForKeyInput;
		protected bool _enableContinuousInputForRayInput;
		protected List<FlUIBase> _nextInputUIList;
		protected List<bool> _nextInputUIExistList;
		protected bool _enableSubmitDelayTimeForRayInput;
		protected float _customSubmitDelayTimeForRayInput;
		protected List<string> _customSubmitButtonNameList;
		protected List<string> _customCancelButtonNameList;
		protected bool _enableDownLoopSelection;
		protected bool _isLoopMotionInDownLoop;
		protected bool _downLoopOnFlag;
		protected bool _isLongDownLoopStart;
		protected float _currentLongDownLoopTime;
		protected float _longDownLoopTime;
		protected bool _isDownInToDownOut;
		protected Hashtable _uiLabelNameTable;
		protected string _labelLoop;
		protected string _labelDisable;
		protected string _labelDownIn;
		protected string _labelDownLoop;
		protected string _labelDownOut;
		protected string _labelSelectIn;
		protected string _labelSelectLoop;
		protected string _labelSelectOut;
		protected string _labelOverIn;
		protected string _labelOverLoop;
		protected string _labelOverOut;
		protected bool _isSwipeStart;
		protected bool _isSwiping;
		protected FlUIDirectionTypes _swipeDirectionType;
		protected Vector3 _swipeVector;
		protected Vector3 _swipeStartFixScreenPosition;
		protected Vector3 _swipeCurrentFixScreenPosition;
		protected Vector3 _swipeStartScreenPosition;
		protected Vector3 _swipeCurrentScreenPosition;
		protected List<FlAction> _actionList;
		protected bool _initializeValueChangeFlag;
		protected bool _executeValueChangeActionFlag;
		protected FlCommonStateTypes _currentValueCnageState;
		protected bool _animationFlag;
		protected bool _inputFlag;
		protected FlUIDirectionTypes _directionType;
		[CompilerGenerated]
		private Action _ActionCommonStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionCommonEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownInStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownInLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownInEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownLoopOn_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownLoopOff_k__BackingField;
		[CompilerGenerated]
		private Action _ActionLongDownLoopStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionLongDownLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutStartOn_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutStartOff_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutEndOn_k__BackingField;
		[CompilerGenerated]
		private Action _ActionDownOutEndOff_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectInStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectInLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectInEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectOutStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectOutLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSelectOutEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverInStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverInLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverInEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverOutStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverOutLoop_k__BackingField;
		[CompilerGenerated]
		private Action _ActionOverOutEnd_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSwipeStart_k__BackingField;
		[CompilerGenerated]
		private Action _ActionSwipeLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionCommonStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionCommonEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownInStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownInLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownInEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownLoopOn_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownLoopOff_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionLongDownLoopStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionLongDownLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutStartOn_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutStartOff_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutEndOn_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionDownOutEndOff_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectInStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectInLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectInEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectOutStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectOutLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSelectOutEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverInStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverInLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverInEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverOutStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverOutLoop_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionOverOutEnd_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSwipeStart_k__BackingField;
		[CompilerGenerated]
		private FlAction _FlActionSwipeLoop_k__BackingField;
	
		// Properties
		public FlComponentBase ComponentBase { get; set; }
		public FlRoot Root { get; }
		public GameObject RootObject { get; }
		public FlMotion Motion { get; }
		public FlObjectBase HitAreaObject { get; }
		public Collider Collider { get; }
		[Obsolete]
		public Collider Collision { get; }
		public bool Exist { get; }
		public bool Enable { get; }
		public FlUIEnableTypes EnableType { get; }
		public bool IsActive { get; }
		public bool ParentEnable { get; }
		public FlUIBaseStateTypes CurrentBaseState { get; }
		public FlInputTypes CurrentInputType { get; }
		public List<string> CustomSubmitButtonNameList { get; }
		public List<string> CustomCancelButtonNameList { get; }
		public float CustomSubmitDelayTimeForRayInput { get; }
		public bool EnableSubmitDelayTimeForRayInput { get; }
		public bool EnableDownLoopForTouchInput { get; }
		public bool EnableDownLoopForKeyInput { get; }
		public bool EnableDownLoopForRayInput { get; }
		public FlUIBase ParentUI { get; }
		public bool EnableSelectInputForTouchInput { get; }
		public bool EnableSelectInputForKeyInput { get; }
		public bool EnableSelectInputForRayInput { get; }
		public bool EnableDownInputForTouchInput { get; }
		public bool EnableDownInputForKeyInput { get; }
		public bool EnableDownInputForRayInput { get; }
		public bool EnableOverInputForMouseInput { get; }
		public bool EnableContinuousInputForTouchInput { get; }
		public bool EnableContinuousInputForKeyInput { get; }
		public bool EnableContinuousInputForRayInput { get; }
		public FlTouchInput CurrentTouchInput { get; }
		public FlKeyInput CurrentKeyInput { get; }
		public FlRayInput CurrentRayInput { get; }
		public bool IsSwiping { get; }
		public FlUIDirectionTypes SwipeDirectionType { get; }
		public FlUIDirectionTypes DirectionType { get; }
		public bool EnableDownLoopSelection { get; }
		public Action ActionCommonStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionCommonEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownInStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownInLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownInEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownLoopOn { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownLoopOff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionLongDownLoopStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionLongDownLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutStartOn { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutStartOff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutEndOn { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionDownOutEndOff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectInStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectInLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectInEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectOutStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectOutLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSelectOutEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverInStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverInLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverInEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverOutStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverOutLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionOverOutEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSwipeStart { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action ActionSwipeLoop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FlAction FlActionCommonStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionCommonEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownInStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownInLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownInEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownLoopOn { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownLoopOff { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionLongDownLoopStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionLongDownLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutStartOn { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutStartOff { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutEndOn { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionDownOutEndOff { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectInStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectInLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectInEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectOutStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectOutLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSelectOutEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverInStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverInLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverInEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverOutStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverOutLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionOverOutEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSwipeStart { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public FlAction FlActionSwipeLoop { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		public enum FlUIBaseStateTypes
		{
			None = 0,
			Loop_Init = 1,
			Loop_Loop = 2,
			DownIn_Init = 3,
			DownIn_Loop = 4,
			DownLoop_Init = 5,
			DownLoop_Loop = 6,
			DownOut_Init = 7,
			DownOut_Loop = 8,
			SelectIn_Init = 9,
			SelectIn_Loop = 10,
			SelectLoop_Init = 11,
			SelectLoop_Loop = 12,
			SelectOut_Init = 13,
			SelectOut_Loop = 14,
			OverIn_Init = 15,
			OverIn_Loop = 16,
			OverLoop_Init = 17,
			OverLoop_Loop = 18,
			OverOut_Init = 19,
			OverOut_Loop = 20
		}
	
		// Constructors
		public FlUIBase();
	
		// Methods
		public virtual void SetBasePath(FlRoot root, GameObject rootObject, string motionPath);
		public virtual void SetHitAreaObject(string hitAreaObjectPath);
		public virtual void Initialize();
		protected virtual bool _InitializeData();
		protected virtual bool _InitializeThisData();
		protected virtual void _InitializeThisData_PostProcess();
		protected virtual void _InitializeInput();
		protected virtual void _InitializeActionList();
		protected virtual void _InitializeLogColor();
		protected virtual void _InitializeUILabelNameTable();
		protected virtual bool _PlayMotion(string labelName, bool force);
		protected virtual bool _PlayMotionBase(string labelName, string secondLabelName, string thirdLabelName, bool force);
		protected virtual bool _IsUILabelName();
		protected virtual void _ResetMotion(bool force);
		protected virtual void _OnActive();
		protected virtual void _OnDeactive();
		protected virtual void _Reset();
		protected virtual void _ResetPrevValue();
		public virtual void _Release();
		public virtual void _UpdateInitialize();
		public virtual void _UpdateFirst();
		public virtual void _UpdateSecond();
		public virtual void _UpdateForce();
		protected virtual void _ForceUpdateStart();
		protected virtual void _ForceUpdateEnd();
		protected virtual void _Update_Common_Start();
		protected virtual void _Update(bool update = true);
		protected virtual void _Update_Common_End();
		protected virtual void _Update_Loop_Init();
		protected virtual void _Update_Loop_Loop();
		protected virtual void _Update_DownIn_Init();
		protected virtual void _Update_DownIn_Loop();
		protected virtual void _Update_DownLoop_Init();
		protected virtual void _Update_DownLoop_Loop();
		protected virtual void _Update_DownOut_Init();
		protected virtual void _Update_DownOut_Loop();
		protected virtual void _Update_DownOut_End();
		protected virtual void _Update_SelectIn_Init();
		protected virtual void _Update_SelectIn_Loop();
		protected virtual void _Update_SelectLoop_Init();
		protected virtual void _Update_SelectLoop_Loop();
		protected virtual void _Update_SelectOut_Init();
		protected virtual void _Update_SelectOut_Loop();
		protected virtual void _Update_SelectOut_End();
		protected virtual void _Update_OverIn_Init();
		protected virtual void _Update_OverIn_Loop();
		protected virtual void _Update_OverLoop_Init();
		protected virtual void _Update_OverLoop_Loop();
		protected virtual void _Update_OverOut_Init();
		protected virtual void _Update_OverOut_Loop();
		protected virtual void _Update_OverOut_End();
		protected virtual void _CheckInitializeValueChange();
		protected virtual void _InitializeValueChange();
		protected virtual void _CheckUpdateValueChange();
		protected virtual void _UpdateValueChange();
		protected virtual void _CheckUpdatePrevValueChange();
		protected virtual void _UpdatePrevValueChange();
		protected virtual void _CheckValueChangeState();
		protected virtual void _UpdateValueChangeState();
		protected virtual void _UpdateValueChangeStart();
		protected virtual void _UpdateValueChangeLoop();
		protected virtual void _UpdateValueChangeEnd();
		protected void _UpdateCollider();
		public virtual void SetEnableDownLoopSelection(bool enable);
		public virtual void SetLongDownLoopTime(bool useDefault, float longDownLoopTime);
		public virtual void SetEnableLoopMotionInDownLoop(bool enable);
		public virtual bool _IsLoopState();
		public virtual bool _IsDownState();
		public virtual bool _IsSelectState();
		public virtual bool _IsOverState();
		protected bool _IsInputDown();
		protected bool _IsInputDownLoop();
		protected FlInputDownLoopTypes _GetInputDownLoopType();
		protected FlInputUpTypes _GetInputUpType();
		protected bool _IsInputSwipeStart(FlUIDirectionTypes directionType);
		protected void _UpdateSwipeValue();
		protected bool _IsInputSelect();
		protected bool _IsInputOver();
		public virtual void SetLoopIn();
		public virtual void SetDownIn();
		public virtual void SetDownLoop();
		public virtual void SetDownInToDownOut();
		public virtual void SetDownOutInRange();
		public virtual void SetDownOutOutRange();
		public virtual void SetSelectIn();
		public virtual void SetSelectLoop();
		public virtual void SetSelectOut();
		public virtual void SetOverIn();
		public virtual void SetOverLoop();
		public virtual void SetOverOut();
		public virtual FlUIBase GetNextInputUI(FlUIInputDirectionTypes inputDirectionType);
		public virtual bool ExistNextInputUI(FlUIInputDirectionTypes inputDirectionType);
		public virtual void SetNextInputUI(FlUIBase targetInputUI, FlUIInputDirectionTypes inputDirectionType);
		public virtual void SetNextInputUI(FlUIBase targetInputUI);
		public virtual void RemoveNextInputUI(FlUIInputDirectionTypes inputDirectionType);
		public virtual void ClearNextInputUI();
		public virtual void SetEnableSubmitDelayTimeForRayInput(bool enable);
		public virtual void SetCustomSubmitDelayTimeForRayInput(float delayTime);
		public virtual void SetEnableDownLoop(bool enable);
		public virtual void SetEnableDownLoop(bool enable, FlInputTypes inputType);
		public virtual void SetEnableOverInput(bool enable);
		public virtual void SetEnableOverInput(bool enable, FlInputTypes inputType);
		public virtual void SetEnableSelectInput(bool enable);
		public virtual void SetEnableSelectInput(bool enable, FlInputTypes inputType);
		public virtual void SetEnableDownInput(bool enable);
		public virtual void SetEnableDownInput(bool enable, FlInputTypes inputType);
		public virtual void SetEnableContinuousInput(bool enable);
		public virtual void SetEnableContinuousInput(bool enable, FlInputTypes inputType);
		public virtual void SetCustomSubmitButtonName(string buttonName);
		public virtual void SetCustomCancelButtonName(string buttonName);
		public virtual void SetParentUI(FlUIBase parentUI);
		public virtual void SetEnable(bool enable);
		[Obsolete]
		public virtual void SetEnableWithGrayscale(bool enable);
		[Obsolete]
		public virtual void SetEnableWithDisableLabel(bool enable);
		public virtual void SetEnable(bool enable, FlUIEnableTypes enableType);
		protected virtual void _UpdateEnable();
		public virtual void SetParentEnable(bool enable);
		public virtual void ResetUpdateDepth();
		public virtual void RemoveAllAction();
		protected virtual void _ExecuteAction(Action action, FlAction flAction);
		protected FlAction _AddAction();
		protected void _ReleaseAction();
		public virtual bool _UpdateUI(object arg);
		protected void _SetLog(FlLogTypes logType);
		protected void _SetErrorLog(FlLogTypes logType);
	}
}
