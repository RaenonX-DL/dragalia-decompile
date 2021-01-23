/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class MaintenanceButtonController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public List<MaintenanceFunctionType> funcTypes;
		[SerializeField]
		private GameObject addingObj;
		[SerializeField]
		public bool isGrayout;
		[SerializeField]
		public bool isAddDisabledColor;
		[SerializeField]
		private Color disabledColor;
		[SerializeField]
		private float addingObjScale;
		private Selectable.Transition tempTransition;
		[CompilerGenerated]
		private bool _isInMaintenance_k__BackingField;
		private static readonly Dictionary<MaintenanceFunctionType, SystemMessage> maintenanceMessageDict;
	
		// Properties
		public bool isInMaintenance { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public List<GameObject> ignoreSetColorChildren;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _UpdateEnableState_b__0(Image x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public List<GameObject> ignoreSetColorChildren;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _UpdateEnableState_b__1(Image x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_2
		{
			// Fields
			public List<GameObject> ignoreSetColorChildren;
	
			// Constructors
			public __c__DisplayClass17_2();
	
			// Methods
			internal void _UpdateEnableState_b__2(Image x);
		}
	
		// Constructors
		public MaintenanceButtonController();
		static MaintenanceButtonController();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetAddingObj(GameObject obj);
		public void AttachMaintenancePUHandler(PointerEventHandler eventHandler);
		private void OnDestroy();
		public void UpdateEnableState(bool needUpdateWhenNotInMaintenanse = false, List<MaintenanceFunctionType> withSwitchFuncTypes = null, bool keepInteractableIsFalse = false);
		public void ShowMaintenanceError();
		public static bool ShowMaintenanceError(MaintenanceFunctionType funcType);
		public static bool ShowMaintenanceError(List<MaintenanceFunctionType> funcTypes);
		[CompilerGenerated]
		private void _AttachMaintenancePUHandler_b__15_0();
	}
}
