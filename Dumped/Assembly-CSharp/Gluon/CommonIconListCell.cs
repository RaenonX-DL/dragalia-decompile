/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIconListCell : TableViewCell<Gluon.CommonIconListCellData>
	{
		// Fields
		[SerializeField]
		protected GameObject frame;
		public CommonIconListCellData data;
		protected CommonUnitIcon icon;
		protected CommonIcon commonIcon;
		protected CommonSkillIcon skillIcon;
		protected WeaponPassiveAbilityIcon weaponPassiveAbilityIcon;
		[SerializeField]
		public CommonIconButtonEvent buttonPressed;
		[SerializeField]
		public CommonIconButtonEvent buttonLongPressed;
		protected CommonIconListCaption caption;
		private int captionAbilityId;
		private string captionTitle;
		protected bool isMoveFirstColmnIcon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitMoment_d__18 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitMoment_d__18(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CommonIconListCell();
	
		// Methods
		protected virtual void Start();
		private void LateUpdate();
		public override void UpdateContent(CommonIconListCellData data);
		public virtual void LoadUnitIcon();
		public void OnButtonPressed();
		public void OnButtonLongPressed();
		[IteratorStateMachine]
		private IEnumerator WaitMoment(UnityAction callback);
		private void OnDestroy();
		public virtual void UpdateSkillContent(SkillListCellData data);
		public virtual void UpdateWeaponPassiveAbilityContent(WeaponPassiveAbilityListCellData data);
	}
}
