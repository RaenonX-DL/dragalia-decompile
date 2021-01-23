/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class BossDropItemBox : DropItemBox
	{
		// Fields
		private List<DropItemUI.Parameter> paramList;
		public int popPriority;
		private EffectType effectType;
		private BossDropItemBoxCtrl ctrl;
		private bool isStartOpenTimer;
		private float openTimer;
	
		// Nested types
		private enum EffectType
		{
			Normal = 0,
			Rare = 1,
			Gorgeous = 2
		}
	
		[CompilerGenerated]
		private sealed class _DropItem_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BossDropItemBox __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DropItem_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BossDropItemBox();
	
		// Methods
		protected override void Start();
		public override void FastUpdate();
		public void SetDropItem(DropItemUI.Parameter param);
		public void SetDisplay(Vector3 position, float rotY);
		protected void OnOpenBossItemBox();
		[IteratorStateMachine]
		protected override IEnumerator DropItem(GameObject target);
	}
}
