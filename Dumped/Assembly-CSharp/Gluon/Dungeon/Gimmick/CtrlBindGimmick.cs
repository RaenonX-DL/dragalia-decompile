/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class CtrlBindGimmick
	{
		// Fields
		private BindGimmick _owner;
		private List<CharacterBase> BindTargets;
		private List<BindInfoData> _bindInfoList;
		private BindAppearance _appearance;
		private bool _canAutoRelease;
		private static long _nextBindEventId;
	
		// Nested types
		public class BindAppearance
		{
			// Fields
			public string effectName;
			public float duration;
			public string seName;
	
			// Constructors
			public BindAppearance();
	
			// Methods
			public static BindAppearance Default();
		}
	
		private struct BindTargetInfoData
		{
			// Fields
			[CompilerGenerated]
			private CharacterBase _TargetChara_k__BackingField;
			[CompilerGenerated]
			private EffectObject _AttachEffect_k__BackingField;
			[CompilerGenerated]
			private bool _FromNetwork_k__BackingField;
	
			// Properties
			public CharacterBase TargetChara { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public EffectObject AttachEffect { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool FromNetwork { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public BindTargetInfoData(CharacterBase target, EffectObject eo, bool fromNetwork);
		}
	
		private class BindInfoData
		{
			// Fields
			public States localState;
			public long bindEventId;
			public List<BindTargetInfoData> targets;
			public MultiPlayWaitingList catchingOtherPlayers;
	
			// Nested types
			public enum States
			{
				None = 0,
				Catching = 1,
				Confirmed = 2,
				Released = 3
			}
	
			// Constructors
			public BindInfoData();
	
			// Methods
			public bool IsUsing();
		}
	
		// Constructors
		public CtrlBindGimmick(BindGimmick owner, bool canAutoRelease, BindAppearance appearance = null);
	
		// Methods
		public void Clear();
		public void Update();
		public bool OnCatch(long bindEventId, CharacterBase targetChara, Vector3 position, bool isDamagePose = false, int effectTrigger = 0);
		public void OnConfirm(long bindEventId);
		public void OnReleaseAll(long bindEventId);
		public void OnReceiveBindEvent(BindEvent recvData);
		private BindTargetInfoData BindCharacter(CharacterBase targetChara, Vector3 position, bool fromNetwork, bool isDamagePose = false, int effectTriger = 0);
		private void UnbindCharacter(ref BindTargetInfoData target);
		private BindInfoData GetBindInfo(long bindEventId);
		private BindTargetInfoData ApplyAppearance(CharacterBase chara, int effectTrigger, bool fromNetwork);
		private void ResetAppearance(ref BindTargetInfoData target);
		private bool CheckAutoRelease(BindInfoData info);
	}
}
