/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPrepareUIStatus : PartyUIStatus
	{
		// Fields
		public QuestPrepareScene questPrepareScene;
		public GameObject disabledImage;
		public PointerEventHandler eventHandler;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public QuestPrepareUIStatus __4__this;
			public AutoPartyConfigData selectData;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _SyncAttributeMatchEffect_b__0();
		}
	
		// Constructors
		public QuestPrepareUIStatus();
	
		// Methods
		public void SetSupportCharaData(int charaId, int charaLevel, int dragonId, int weaponId);
		public override void OnEquipChangeButtonPressed();
		public void OnShareSkillPopupReload();
		public new void EmptyFramePressed(int tag);
		public override void SyncAttributeMatchEffect(AutoPartyConfigData selectData = null);
	}
}
