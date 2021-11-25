using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlUIBase
	{
		public enum FlUIBaseStateTypes
		{
			None,
			Loop_Init,
			Loop_Loop,
			DownIn_Init,
			DownIn_Loop,
			DownLoop_Init,
			DownLoop_Loop,
			DownOut_Init,
			DownOut_Loop,
			SelectIn_Init,
			SelectIn_Loop,
			SelectLoop_Init,
			SelectLoop_Loop,
			SelectOut_Init,
			SelectOut_Loop,
			OverIn_Init,
			OverIn_Loop,
			OverLoop_Init,
			OverLoop_Loop,
			OverOut_Init,
			OverOut_Loop
		}

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

		public FlComponentBase ComponentBase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FlRoot Root => null;

		public GameObject RootObject => null;

		public FlMotion Motion => null;

		public FlObjectBase HitAreaObject => null;

		public Collider Collider => null;

		[Obsolete]
		public Collider Collision => null;

		public bool Exist => default(bool);

		public bool Enable => default(bool);

		public FlUIEnableTypes EnableType => default(FlUIEnableTypes);

		public bool IsActive => default(bool);

		public bool ParentEnable => default(bool);

		public FlUIBaseStateTypes CurrentBaseState => default(FlUIBaseStateTypes);

		public FlInputTypes CurrentInputType => default(FlInputTypes);

		public List<string> CustomSubmitButtonNameList => null;

		public List<string> CustomCancelButtonNameList => null;

		public float CustomSubmitDelayTimeForRayInput => default(float);

		public bool EnableSubmitDelayTimeForRayInput => default(bool);

		public bool EnableDownLoopForTouchInput => default(bool);

		public bool EnableDownLoopForKeyInput => default(bool);

		public bool EnableDownLoopForRayInput => default(bool);

		public FlUIBase ParentUI => null;

		public bool EnableSelectInputForTouchInput => default(bool);

		public bool EnableSelectInputForKeyInput => default(bool);

		public bool EnableSelectInputForRayInput => default(bool);

		public bool EnableDownInputForTouchInput => default(bool);

		public bool EnableDownInputForKeyInput => default(bool);

		public bool EnableDownInputForRayInput => default(bool);

		public bool EnableOverInputForMouseInput => default(bool);

		public bool EnableContinuousInputForTouchInput => default(bool);

		public bool EnableContinuousInputForKeyInput => default(bool);

		public bool EnableContinuousInputForRayInput => default(bool);

		public FlTouchInput CurrentTouchInput => null;

		public FlKeyInput CurrentKeyInput => null;

		public FlRayInput CurrentRayInput => null;

		public bool IsSwiping => default(bool);

		public FlUIDirectionTypes SwipeDirectionType => default(FlUIDirectionTypes);

		public FlUIDirectionTypes DirectionType => default(FlUIDirectionTypes);

		public bool EnableDownLoopSelection => default(bool);

		public Action ActionCommonStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionCommonEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownLoopOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownLoopOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionLongDownLoopStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionLongDownLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutStartOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutStartOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutEndOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionDownOutEndOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSelectOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionOverOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSwipeStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action ActionSwipeLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FlAction FlActionCommonStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionCommonEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownLoopOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownLoopOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionLongDownLoopStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionLongDownLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutStartOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutStartOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutEndOn
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionDownOutEndOff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSelectOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverInStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverInLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverInEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverOutStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverOutLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionOverOutEnd
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSwipeStart
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public FlAction FlActionSwipeLoop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual void SetBasePath(FlRoot root, GameObject rootObject, string motionPath)
		{
		}

		public virtual void SetHitAreaObject(string hitAreaObjectPath)
		{
		}

		public virtual void Initialize()
		{
		}

		protected virtual bool _InitializeData()
		{
			return default(bool);
		}

		protected virtual bool _InitializeThisData()
		{
			return default(bool);
		}

		protected virtual void _InitializeThisData_PostProcess()
		{
		}

		protected virtual void _InitializeInput()
		{
		}

		protected virtual void _InitializeActionList()
		{
		}

		protected virtual void _InitializeLogColor()
		{
		}

		protected virtual void _InitializeUILabelNameTable()
		{
		}

		protected virtual bool _PlayMotion(string labelName, bool force)
		{
			return default(bool);
		}

		protected virtual bool _PlayMotionBase(string labelName, string secondLabelName, string thirdLabelName, bool force)
		{
			return default(bool);
		}

		protected virtual bool _IsUILabelName()
		{
			return default(bool);
		}

		protected virtual void _ResetMotion(bool force)
		{
		}

		protected virtual void _OnActive()
		{
		}

		protected virtual void _OnDeactive()
		{
		}

		protected virtual void _Reset()
		{
		}

		protected virtual void _ResetPrevValue()
		{
		}

		public virtual void _Release()
		{
		}

		public virtual void _UpdateInitialize()
		{
		}

		public virtual void _UpdateFirst()
		{
		}

		public virtual void _UpdateSecond()
		{
		}

		public virtual void _UpdateForce()
		{
		}

		protected virtual void _ForceUpdateStart()
		{
		}

		protected virtual void _ForceUpdateEnd()
		{
		}

		protected virtual void _Update_Common_Start()
		{
		}

		protected virtual void _Update(bool update = true)
		{
		}

		protected virtual void _Update_Common_End()
		{
		}

		protected virtual void _Update_Loop_Init()
		{
		}

		protected virtual void _Update_Loop_Loop()
		{
		}

		protected virtual void _Update_DownIn_Init()
		{
		}

		protected virtual void _Update_DownIn_Loop()
		{
		}

		protected virtual void _Update_DownLoop_Init()
		{
		}

		protected virtual void _Update_DownLoop_Loop()
		{
		}

		protected virtual void _Update_DownOut_Init()
		{
		}

		protected virtual void _Update_DownOut_Loop()
		{
		}

		protected virtual void _Update_DownOut_End()
		{
		}

		protected virtual void _Update_SelectIn_Init()
		{
		}

		protected virtual void _Update_SelectIn_Loop()
		{
		}

		protected virtual void _Update_SelectLoop_Init()
		{
		}

		protected virtual void _Update_SelectLoop_Loop()
		{
		}

		protected virtual void _Update_SelectOut_Init()
		{
		}

		protected virtual void _Update_SelectOut_Loop()
		{
		}

		protected virtual void _Update_SelectOut_End()
		{
		}

		protected virtual void _Update_OverIn_Init()
		{
		}

		protected virtual void _Update_OverIn_Loop()
		{
		}

		protected virtual void _Update_OverLoop_Init()
		{
		}

		protected virtual void _Update_OverLoop_Loop()
		{
		}

		protected virtual void _Update_OverOut_Init()
		{
		}

		protected virtual void _Update_OverOut_Loop()
		{
		}

		protected virtual void _Update_OverOut_End()
		{
		}

		protected virtual void _CheckInitializeValueChange()
		{
		}

		protected virtual void _InitializeValueChange()
		{
		}

		protected virtual void _CheckUpdateValueChange()
		{
		}

		protected virtual void _UpdateValueChange()
		{
		}

		protected virtual void _CheckUpdatePrevValueChange()
		{
		}

		protected virtual void _UpdatePrevValueChange()
		{
		}

		protected virtual void _CheckValueChangeState()
		{
		}

		protected virtual void _UpdateValueChangeState()
		{
		}

		protected virtual void _UpdateValueChangeStart()
		{
		}

		protected virtual void _UpdateValueChangeLoop()
		{
		}

		protected virtual void _UpdateValueChangeEnd()
		{
		}

		protected void _UpdateCollider()
		{
		}

		public virtual void SetEnableDownLoopSelection(bool enable)
		{
		}

		public virtual void SetLongDownLoopTime(bool useDefault, float longDownLoopTime)
		{
		}

		public virtual void SetEnableLoopMotionInDownLoop(bool enable)
		{
		}

		public virtual bool _IsLoopState()
		{
			return default(bool);
		}

		public virtual bool _IsDownState()
		{
			return default(bool);
		}

		public virtual bool _IsSelectState()
		{
			return default(bool);
		}

		public virtual bool _IsOverState()
		{
			return default(bool);
		}

		protected bool _IsInputDown()
		{
			return default(bool);
		}

		protected bool _IsInputDownLoop()
		{
			return default(bool);
		}

		protected FlInputDownLoopTypes _GetInputDownLoopType()
		{
			return default(FlInputDownLoopTypes);
		}

		protected FlInputUpTypes _GetInputUpType()
		{
			return default(FlInputUpTypes);
		}

		protected bool _IsInputSwipeStart(FlUIDirectionTypes directionType)
		{
			return default(bool);
		}

		protected void _UpdateSwipeValue()
		{
		}

		protected bool _IsInputSelect()
		{
			return default(bool);
		}

		protected bool _IsInputOver()
		{
			return default(bool);
		}

		public virtual void SetLoopIn()
		{
		}

		public virtual void SetDownIn()
		{
		}

		public virtual void SetDownLoop()
		{
		}

		public virtual void SetDownInToDownOut()
		{
		}

		public virtual void SetDownOutInRange()
		{
		}

		public virtual void SetDownOutOutRange()
		{
		}

		public virtual void SetSelectIn()
		{
		}

		public virtual void SetSelectLoop()
		{
		}

		public virtual void SetSelectOut()
		{
		}

		public virtual void SetOverIn()
		{
		}

		public virtual void SetOverLoop()
		{
		}

		public virtual void SetOverOut()
		{
		}

		public virtual FlUIBase GetNextInputUI(FlUIInputDirectionTypes inputDirectionType)
		{
			return null;
		}

		public virtual bool ExistNextInputUI(FlUIInputDirectionTypes inputDirectionType)
		{
			return default(bool);
		}

		public virtual void SetNextInputUI(FlUIBase targetInputUI, FlUIInputDirectionTypes inputDirectionType)
		{
		}

		public virtual void SetNextInputUI(FlUIBase targetInputUI)
		{
		}

		public virtual void RemoveNextInputUI(FlUIInputDirectionTypes inputDirectionType)
		{
		}

		public virtual void ClearNextInputUI()
		{
		}

		public virtual void SetEnableSubmitDelayTimeForRayInput(bool enable)
		{
		}

		public virtual void SetCustomSubmitDelayTimeForRayInput(float delayTime)
		{
		}

		public virtual void SetEnableDownLoop(bool enable)
		{
		}

		public virtual void SetEnableDownLoop(bool enable, FlInputTypes inputType)
		{
		}

		public virtual void SetEnableOverInput(bool enable)
		{
		}

		public virtual void SetEnableOverInput(bool enable, FlInputTypes inputType)
		{
		}

		public virtual void SetEnableSelectInput(bool enable)
		{
		}

		public virtual void SetEnableSelectInput(bool enable, FlInputTypes inputType)
		{
		}

		public virtual void SetEnableDownInput(bool enable)
		{
		}

		public virtual void SetEnableDownInput(bool enable, FlInputTypes inputType)
		{
		}

		public virtual void SetEnableContinuousInput(bool enable)
		{
		}

		public virtual void SetEnableContinuousInput(bool enable, FlInputTypes inputType)
		{
		}

		public virtual void SetCustomSubmitButtonName(string buttonName)
		{
		}

		public virtual void SetCustomCancelButtonName(string buttonName)
		{
		}

		public virtual void SetParentUI(FlUIBase parentUI)
		{
		}

		public virtual void SetEnable(bool enable)
		{
		}

		[Obsolete]
		public virtual void SetEnableWithGrayscale(bool enable)
		{
		}

		[Obsolete]
		public virtual void SetEnableWithDisableLabel(bool enable)
		{
		}

		public virtual void SetEnable(bool enable, FlUIEnableTypes enableType)
		{
		}

		protected virtual void _UpdateEnable()
		{
		}

		public virtual void SetParentEnable(bool enable)
		{
		}

		public virtual void ResetUpdateDepth()
		{
		}

		public virtual void RemoveAllAction()
		{
		}

		protected virtual void _ExecuteAction(Action action, FlAction flAction)
		{
		}

		protected FlAction _AddAction()
		{
			return null;
		}

		protected void _ReleaseAction()
		{
		}

		public virtual bool _UpdateUI(object arg)
		{
			return default(bool);
		}

		protected void _SetLog(FlLogTypes logType)
		{
		}

		protected void _SetErrorLog(FlLogTypes logType)
		{
		}
	}
}
