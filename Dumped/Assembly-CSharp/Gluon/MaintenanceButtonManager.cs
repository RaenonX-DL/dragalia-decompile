/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MaintenanceButtonManager : SingletonMonoBehaviour<Gluon.MaintenanceButtonManager>
	{
		// Fields
		private List<MaintenanceButtonController> controllers;
		private List<MaintenanceFunctionType> currentFunctionalMaintenanceList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<MaintenanceButtonController> __9__3_0;
			public static Predicate<MaintenanceButtonController> __9__4_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Register_b__3_0(MaintenanceButtonController item);
			internal bool _UnRegister_b__4_0(MaintenanceButtonController item);
		}
	
		// Constructors
		public MaintenanceButtonManager();
	
		// Methods
		protected override void Awake();
		public void Register(MaintenanceButtonController controller);
		public void UnRegister(MaintenanceButtonController controller);
		public void UnRegisterAll();
		public void UpdateEnableState();
		public static bool IsInMaintenance(List<MaintenanceFunctionType> funcTypes);
		public static bool IsInMaintenance(MaintenanceFunctionType funcType);
		public static SystemMessage GetMaintenanceResultCodeByFunctionType(MaintenanceFunctionType type);
		public static bool IsMaintenanceResultCode(int n);
	}
}
