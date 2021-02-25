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
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class Switch : DungeonObjectBase
	{
		// Fields
		private static readonly SwitchDirectionData[] switchDirectionDataArray;
		public SwitchGimmickKind switchGimmickKind;
		[SerializeField]
		private int putEffectkickTrigger;
		public GameObject targetDoor;
		private bool hitted;
		private SwitchDoor doorComponent;
		private EffectObject effLoop;
	
		// Properties
		public override bool considerColliderOffsetHeight { get; }
	
		// Nested types
		private class SwitchDirectionData
		{
			// Fields
			public static readonly Localize.TextId ignoreTextLabel;
			public string loopEffectLabel;
			public Vector3 loopEffectOffset;
			public string hitEffectLabel;
			public Vector3 hitEffectOffset;
			public string hitSoundLabel;
			public float putDelaySec;
			public string putEffectLabel;
			public Vector3 putEffectOffset;
			public string putSoundLabel;
			public bool putWaitSwitchAnime;
			public float doorDelaySec;
			public float doorDisableColliderDelaySec;
			public string doorEffectLabel;
			public Vector3 doorEffectOffset;
			public Localize.TextId doorTextLabel;
	
			// Constructors
			public SwitchDirectionData(string loopEffectLabel, Vector3 loopEffectOffset, string hitEffectLabel, Vector3 hitEffectOffset, float putDelaySec, string putEffectLabel, Vector3 putEffectOffset, bool putWaitSwitchAnime, float doorDelaySec, string doorEffectLabel, Vector3 doorEffectOffset, float doorDisableColliderDelaySec, string hitSoundLabel, string putSoundLabel, Localize.TextId doorTextLabel);
			static SwitchDirectionData();
		}
	
		public enum SwitchGimmickKind
		{
			Default = 0,
			Hanebashi = 1,
			EnumMax = 2
		}
	
		[CompilerGenerated]
		private sealed class _StartAction_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Switch __4__this;
			public GameObject target;
			private CharacterBase _chara_5__2;
			private SwitchDirectionData _fxData_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__17(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public Switch();
		static Switch();
	
		// Methods
		public virtual bool IsOpened();
		protected override void Awake();
		protected override void Start();
		public override void FastUpdate();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private void OnCollided(GameObject target, bool fromEvent);
		[IteratorStateMachine]
		protected IEnumerator StartAction(GameObject target);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override bool CanDetectedForAutoPlayMode();
		protected EffectObject PlayEffectSwitch(string label, Vector3 offset);
		protected EffectObject PlayEffectDoor(string label, Vector3 offset);
		protected void PlaySoundChara(CharacterBase chara, string label);
	}
}
