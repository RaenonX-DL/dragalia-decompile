/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
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
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public CharaDataElement masterCharaData;
			public QuestPrepareUIStatus __4__this;
	
			// Constructors
			public __c__DisplayClass5_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_1
		{
			// Fields
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public __c__DisplayClass5_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass5_1();
	
			// Methods
			internal void _Reload_b__2();
			internal void _Reload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_2
		{
			// Fields
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public __c__DisplayClass5_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass5_2();
	
			// Methods
			internal void _Reload_b__5();
			internal void _Reload_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public QuestPrepareUIStatus __4__this;
			public AutoPartyConfigData selectData;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _SyncAttributeMatchEffect_b__0();
		}
	
		// Constructors
		public QuestPrepareUIStatus();
	
		// Methods
		public void SetSupportCharaData(int charaId, int charaLevel, int dragonId, int weaponId);
		public override void OnEquipChangeButtonPressed();
		public override void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int type3Crest1Id, int type3Crest2Id, int skill3CharaId = 0, int skill4CharaId = 0);
		public void OnShareSkillPopupReload();
		public new void EmptyFramePressed(int tag);
		public override void SyncAttributeMatchEffect(AutoPartyConfigData selectData = null);
		[CompilerGenerated]
		private void _Reload_b__5_1(Material dragonIconMaterial);
		[CompilerGenerated]
		private void _Reload_b__5_0(Material dragonIconMaterial);
		[CompilerGenerated]
		private void _Reload_b__5_4(Material weaponIconMaterial);
		[CompilerGenerated]
		private void _Reload_b__5_7(Material weaponIconMaterial);
	}
}
