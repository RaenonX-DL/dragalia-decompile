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
	public class PurchaseStoneModel
	{
		// Fields
		private static PurchaseStoneModel instance;
		public Action onModuleCompletedWithAnyAction;
		public Action onModuleCancelled;
		private bool anyActionDone;
		private DestroyStateWatcher destroyWatcher;
		[CompilerGenerated]
		private bool _isDialog_k__BackingField;
		[CompilerGenerated]
		private Transform _frameParent_k__BackingField;
		[CompilerGenerated]
		private RectTransform _referenceRect_k__BackingField;
		[CompilerGenerated]
		private PurchaseStonePopup _modulePopup_k__BackingField;
	
		// Properties
		public static PurchaseStoneModel Instance { get; }
		public bool isDialog { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform frameParent { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public RectTransform referenceRect { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PurchaseStonePopup modulePopup { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		private PurchaseStoneModel();
		static PurchaseStoneModel();
	
		// Methods
		public static bool HasInstance();
		public static void DeleteInstance();
		public void InitModule(GameObject destroyWatcherAttach, Action onCompleted, Action onCancelled, bool isDialog, Transform frameParent, RectTransform referenceRect);
		public void RegisterModuleMainPopup(PurchaseStonePopup popup);
		public void RaiseAnyActionDone();
		public static void QuitModuleIfCreated();
		public void TerminateModule();
		public void QuitModule();
	}
}
