/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareEditPartyPopup : PopupBase
	{
		// Fields
		[CompilerGenerated]
		private QuestPrepareScene _questPrepareScene_k__BackingField;
		public Button clearPartyButton;
		[SerializeField]
		private Button disableClearPartyButton;
		public Button normalPartyButton;
	
		// Properties
		public QuestPrepareScene questPrepareScene { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public AutoPartySelectDialog autoPartySelectDialog;
			public QuestPrepareEditPartyPopup __4__this;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _OnAutoPartyButtonTouched_b__0();
			internal void _OnAutoPartyButtonTouched_b__2();
			internal void _OnAutoPartyButtonTouched_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<ErrorType, int> __9__12_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnAutoPartyButtonTouched_b__12_3(ErrorType type, int resultCode);
		}
	
		// Constructors
		public QuestPrepareEditPartyPopup();
	
		// Methods
		protected override void Start();
		private void SetClearPartyEnable(bool enable);
		public void OnClearPartyButtonTouched();
		public void OnNormalPartyButtonTouched();
		private void OnCharactersExchangeByJumping();
		public void OnAutoPartyButtonTouched();
		public void OnCharaPartyButtonTouched();
		public void OnBgTouched();
		[CompilerGenerated]
		private void _OnCharaPartyButtonTouched_b__13_0();
	}
}
