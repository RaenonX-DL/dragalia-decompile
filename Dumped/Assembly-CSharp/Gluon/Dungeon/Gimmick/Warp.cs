/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class Warp : GimmickBase
	{
		// Fields
		protected DirectionData[] directionDataArray;
		protected string screenEffectLabel;
		protected int screenEffectTriggerId;
		protected string screenSoundLabel;
		protected float[] waitSecForMeArray;
		protected float[] waitSecForOthersArray;
		[CompilerGenerated]
		private bool _IsFinishedWarp_k__BackingField;
		[CompilerGenerated]
		private CharacterSelector _WarpOtherTarget_k__BackingField;
		[SerializeField]
		protected FogData warpOutFogData;
		[SerializeField]
		private float ignoreDamageSec;
		[HideInInspector]
		public GimmickWarpObj type;
		[FormerlySerializedAs]
		public int myWarpIndex;
		[FormerlySerializedAs]
		public int jumpToWarpIndex;
		private HashSet<int> victim;
		protected Transform jumpToTransform;
		protected Warp targetWarp;
		private GimmickWarpObjElement variation;
		protected EffectObject effectObject;
		private EffectObject effectObjectScreen;
		[SerializeField]
		private bool ignoreDirectionEffectFlag;
		[SerializeField]
		private bool ignoreDirectionSoundFlag;
		[SerializeField]
		private bool enableWarpJump;
		[SerializeField]
		private bool warpIsOnceFlag;
		[SerializeField]
		private bool dragonCantWarpFlag;
		[SerializeField]
		private WarpedOptionType warpedOptionType;
		[Lock]
		public List<CharacterBase> warpedCharaList;
		[SerializeField]
		private bool cantReEntryFlag;
		protected static List<CharacterBase> ignoreHitCharaList;
	
		// Properties
		public bool IsFinishedWarp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterSelector WarpOtherTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum DirectionType
		{
			Idle = 0,
			Warp_Start1 = 1,
			Warp_Start2 = 2,
			Warp_Player = 3,
			Warp_Move = 4,
			Warp_Out = 5,
			ReturnToIdle = 6,
			EnumMax = 7
		}
	
		public enum WaitSecForMeType
		{
			Start1 = 0,
			Out1 = 1,
			Out2 = 2,
			Out3 = 3,
			EnumMax = 4
		}
	
		public enum WaitSecForOthersType
		{
			Start1 = 0,
			Out1 = 1,
			Out2 = 2,
			EnumMax = 3
		}
	
		[Serializable]
		public class DirectionData
		{
			// Fields
			public string normalEffectLabel;
			public int normalEffectTriggerId;
			public string notDispEffectLabel1;
			public int notDispEffectTriggerId1;
			public EffectObject.EraseType notDispEffectType1;
			public string notDispEffectLabel2;
			public int notDispEffectTriggerId2;
			public EffectObject.EraseType notDispEffectType2;
			public string soundLabel;
	
			// Constructors
			public DirectionData(string normalEffectLabel = null, int normalEffectTriggerId = 0, string soundLabel = null, string notDispEffectLabel1 = null, int notDispEffectTriggerId1 = 0, EffectObject.EraseType notDispEffectType1 = EffectObject.EraseType.STOP, string notDispEffectLabel2 = null, int notDispEffectTriggerId2 = 0, EffectObject.EraseType notDispEffectType2 = EffectObject.EraseType.STOP);
		}
	
		protected class TargetData
		{
			// Fields
			public CharacterBase hitChara;
			public List<CharacterSelector> selectorList;
			public List<CharacterBase> currentCharaList;
	
			// Constructors
			public TargetData();
		}
	
		[Serializable]
		public class FogData
		{
			// Fields
			public ChangeType changeType;
			public Color fogColor;
			public float startValue;
			public float endValue;
	
			// Nested types
			public enum ChangeType
			{
				Disable = 0,
				Enable = 1,
				ResetToDefault = 2
			}
	
			// Constructors
			public FogData();
		}
	
		public enum WarpedOptionType
		{
			None = 0,
			AddDragonNgFlag = 1,
			RemoveDragonNgFlag = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__57_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _StartWarp_b__57_0();
		}
	
		[CompilerGenerated]
		private sealed class _StartWarp_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Warp __4__this;
			public Collider other;
			public bool checkIsDead;
			public int id;
			private TargetData _targetData_5__2;
			private List<CharacterSelector> _playerCharacters_5__3;
			private Vector3 _pos_5__4;
			private float _time_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartWarp_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartWarpOther_d__58 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GameObject target;
			public Warp __4__this;
			private TargetData _targetData_5__2;
			private float _time_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartWarpOther_d__58(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _InitDirection_d__65 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Warp __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitDirection_d__65(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Warp();
		static Warp();
	
		// Methods
		public bool IsEnableWarp();
		public virtual void SetEnableWarp(bool enableFlag);
		protected virtual void AddWarpedCharaList(CharacterBase chara);
		public static void RemoveReEntryList(CharacterBase tempChara);
		protected override void Awake();
		protected virtual void InitJumpToTransform();
		protected Warp GetLinkWarpScript(int targetIndex);
		public void AddVictim(int id);
		public bool IsVictim(int id);
		public void SetWarp(CharacterBase chara, bool checkIsDead, bool isForceReturn);
		public void SetWarp(Collider other, bool checkIsDead, bool isForceReturn);
		public bool IsWarpOK(Collider other);
		public bool IsWarpOK(CharacterBase chara, bool drawMessage = false);
		public virtual void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		protected CharacterBase GetCharaFromCollider(Collider other);
		[IteratorStateMachine]
		protected virtual IEnumerator StartWarp(int id, Collider other, bool checkIsDead);
		[IteratorStateMachine]
		protected virtual IEnumerator StartWarpOther(GameObject target);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public virtual void OnFinishWarp();
		protected virtual void SetWarpedCharaDataPre(TargetData targetData);
		protected virtual void SetWarpedCharaData(TargetData targetData);
		protected void CancelDragonTransform(CharacterBase tempChara);
		private float GetCameraFollowRateFunc();
		[IteratorStateMachine]
		protected virtual IEnumerator InitDirection();
		protected virtual void SetDirection(DirectionType type, CharacterBase chara = null);
		protected virtual void SetDirection(DirectionType type, List<CharacterBase> charas);
	}
}
