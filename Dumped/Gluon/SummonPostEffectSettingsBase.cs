using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class SummonPostEffectSettingsBase : MonoBehaviour
	{
		[Serializable]
		public class SettingBase
		{
			public int frame;
		}

		public enum SettingSetType
		{
			Shot0102,
			Shot03
		}

		[SerializeField]
		public PostEffect targetPostEffect;

		private Coroutine shot0102Coroutine;

		private Coroutine shot03Coroutine;

		protected SettingBase[] shot0102SettingListBase => null;

		protected SettingBase[] shot03SettingListBase => null;

		public void ScheduleStagePostEffect(SettingSetType type)
		{
		}

		private IEnumerator StageShotPostEffectCoroutine(SettingBase[] settingList)
		{
			return null;
		}

		public void TerminateScheduledPostEffect(SettingSetType type)
		{
		}

		public void ResetByEditor()
		{
		}

		protected virtual SettingBase[] GetShot0102SettingListBase()
		{
			return null;
		}

		protected virtual SettingBase[] GetShot03SettingListBase()
		{
			return null;
		}

		public virtual void ApplyToPostEffect(SettingBase settingBase)
		{
		}
	}
}
