/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPostEffectSettingsBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public PostEffect targetPostEffect;
		private Coroutine shot0102Coroutine;
		private Coroutine shot03Coroutine;
	
		// Properties
		protected SettingBase[] shot0102SettingListBase { get; }
		protected SettingBase[] shot03SettingListBase { get; }
	
		// Nested types
		[Serializable]
		public class SettingBase
		{
			// Fields
			public int frame;
	
			// Constructors
			public SettingBase();
		}
	
		public enum SettingSetType
		{
			Shot0102 = 0,
			Shot03 = 1
		}
	
		[CompilerGenerated]
		private sealed class _StageShotPostEffectCoroutine_d__2 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SettingBase[] settingList;
			public SummonPostEffectSettingsBase __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StageShotPostEffectCoroutine_d__2(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonPostEffectSettingsBase();
	
		// Methods
		public void ScheduleStagePostEffect(SettingSetType type);
		[IteratorStateMachine]
		private IEnumerator StageShotPostEffectCoroutine(SettingBase[] settingList);
		public void TerminateScheduledPostEffect(SettingSetType type);
		public void ResetByEditor();
		protected virtual SettingBase[] GetShot0102SettingListBase();
		protected virtual SettingBase[] GetShot03SettingListBase();
		public virtual void ApplyToPostEffect(SettingBase settingBase);
	}
}
