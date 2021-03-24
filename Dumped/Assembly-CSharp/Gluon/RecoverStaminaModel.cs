/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaModel
	{
		// Fields
		private static RecoverStaminaModel instance;
		public StaminaUtilBase staminaUtil;
		public int requiredStamina;
		public Action onModuleCompletedWithAnyAction;
		public Action onModuleCancelled;
		private bool anyActionDone;
		private DestroyStateWatcher destroyWatcher;
	
		// Properties
		public static RecoverStaminaModel Instance { get; }
	
		// Constructors
		private RecoverStaminaModel();
		static RecoverStaminaModel();
	
		// Methods
		public static bool HasInstance();
		public static void DeleteInstance();
		public void InitModule(GameObject destroyWatcherAttach, bool isMulti, int requiredStamina, Action onCompleted, Action onCancelled);
		public void RaiseAnyActionDone();
		public static void QuitModuleIfCreated();
		public void TerminateModule();
		public void QuitModule();
	}
}
