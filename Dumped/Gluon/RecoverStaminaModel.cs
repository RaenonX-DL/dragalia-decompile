using System;
using UnityEngine;

namespace Gluon
{
	public class RecoverStaminaModel
	{
		private static RecoverStaminaModel instance;

		public StaminaUtilBase staminaUtil;

		public int requiredStamina;

		public Action onModuleCompletedWithAnyAction;

		public Action onModuleCancelled;

		private bool anyActionDone;

		private DestroyStateWatcher destroyWatcher;

		public static RecoverStaminaModel Instance => null;

		public static bool HasInstance()
		{
			return default(bool);
		}

		public static void DeleteInstance()
		{
		}

		private RecoverStaminaModel()
		{
		}

		static RecoverStaminaModel()
		{
		}

		public void InitModule(GameObject destroyWatcherAttach, bool isMulti, int requiredStamina, Action onCompleted, Action onCancelled)
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
