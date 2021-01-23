/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemBase : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public float activateIntervalSec;
		private float elapsedSec;
		public Vector3 position;
		private int itemShaderPropertyId;
		private Renderer targetRenderer;
		private Material targetMaterial;
		private bool caughtFlag;
		[CompilerGenerated]
		private BRItemParam _itemParam_k__BackingField;
		public static readonly float rotationScaleDefault;
		public float rotationScale;
		private static readonly float checkRadItemToBush;
		private static readonly float checkRadItemToPlayer;
		private List<BushClip> bushClipList;
		private float updateShaderParamTimer;
	
		// Properties
		public BRItemId Id { get; }
		public BRItemParam itemParam { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CoGotItemDirection_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BRItemBase __4__this;
			public CharacterBase chara;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoGotItemDirection_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BRItemBase();
		static BRItemBase();
	
		// Methods
		public virtual void SetItemParam(BRItemParam param);
		protected virtual void OnEnable();
		protected void Awake();
		protected virtual void Update();
		protected void UpdateShaderParam();
		private bool IsInside(Vector3 pos1, Vector3 pos2, float rad);
		public void SetInBush(BushClip bushScr, bool enterFlag);
		public void SetInHouse(bool insideWithPlayer);
		private void OnTriggerEnter(Collider other);
		private void OnTriggerStay(Collider other);
		private void TriggerCore(Collider other, bool enterFlag);
		public bool CanGetItem();
		public virtual void OnGotItem(CharacterBase chara);
		[IteratorStateMachine]
		private IEnumerator CoGotItemDirection(CharacterBase chara);
		private void SetCantGetItemDirection();
		protected virtual void Apply(CharacterBase chara);
		public virtual bool IsEffectiveFor(CharacterBase chara);
		public void OnDelete();
		private void SendRequestGetItem(CharacterBase chara);
		public BattleRoyalDungeonItemElement GetItemElem();
	}
}
