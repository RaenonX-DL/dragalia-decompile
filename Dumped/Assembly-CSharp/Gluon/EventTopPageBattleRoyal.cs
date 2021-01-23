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
	public class EventTopPageBattleRoyal : EventTopPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected Button enterBattleButton;
		[SerializeField]
		protected Button selectSkinButton;
		[SerializeField]
		protected Button recordButton;
		[Header]
		[SerializeField]
		protected GameObject lockButton;
		[SerializeField]
		protected Color disabledColor;
		private bool isAvailable;
		private DateTime startDT;
		private DateTime endDT;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public List<GameObject> ignoreSetColorChildren;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _Start_b__0(Transform x);
		}
	
		// Constructors
		public EventTopPageBattleRoyal();
	
		// Methods
		protected override void SetDurationText();
		protected override void Start();
		public void OnLockButtonPressed();
		public void OnEnterBattleButtonPressed();
		public void OnSelectSkinButtonPressed();
		public void OnRecordButtonPressed();
		[CompilerGenerated]
		private void _OnEnterBattleButtonPressed_b__11_0();
		[CompilerGenerated]
		private void _OnSelectSkinButtonPressed_b__12_0();
		[CompilerGenerated]
		private void _OnRecordButtonPressed_b__13_0();
	}
}
