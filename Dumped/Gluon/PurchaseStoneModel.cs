using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class PurchaseStoneModel
	{
		private static PurchaseStoneModel instance;

		public Action onModuleCompletedWithAnyAction;

		public Action onModuleCancelled;

		private bool anyActionDone;

		private DestroyStateWatcher destroyWatcher;

		public static PurchaseStoneModel Instance => null;

		public bool isDialog
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform frameParent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public RectTransform referenceRect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public PurchaseStonePopup modulePopup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool HasInstance()
		{
			return default(bool);
		}

		public static void DeleteInstance()
		{
		}

		private PurchaseStoneModel()
		{
		}

		static PurchaseStoneModel()
		{
		}

		public void InitModule(GameObject destroyWatcherAttach, Action onCompleted, Action onCancelled, bool isDialog, Transform frameParent, RectTransform referenceRect)
		{
		}

		public void RegisterModuleMainPopup(PurchaseStonePopup popup)
		{
		}

		public void RaiseAnyActionDone()
		{
		}

		public static void QuitModuleIfCreated()
		{
		}

		public void TerminateModule()
		{
		}

		public void QuitModule()
		{
		}
	}
}
