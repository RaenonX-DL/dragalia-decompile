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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class BreakableGimmick : DungeonObjectBase
	{
		// Fields
		private GimmickDurablePillarElement variationData;
		[Lock]
		[SerializeField]
		private string soundLabelDamage;
		[Lock]
		[SerializeField]
		private string soundLabelBreak;
		[Lock]
		[SerializeField]
		private string effectLabelBreak;
		private EffectObject effectObj;
		[Lock]
		[SerializeField]
		private int effectTriggerDamage;
		[Lock]
		[SerializeField]
		private int effectTriggerBreak;
		[Lock]
		[SerializeField]
		private float lifeMax;
		private float lifeNow;
		private bool eventInitializedFlag;
		private int changeModelDataIndex;
		[SerializeField]
		private ModelData[] changeModelDataArray;
		[SerializeField]
		private GameObject[] lastRemoveObjectArray;
		private bool hitFlag;
		private static readonly int disableCollisionOffsetY;
	
		// Nested types
		[Serializable]
		public class ModelData
		{
			// Fields
			[Range]
			public float activeRate;
			public GameObject activeObject;
	
			// Constructors
			public ModelData(float rate);
		}
	
		[CompilerGenerated]
		private sealed class _StartAction_d__17 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BreakableGimmick __4__this;
	
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
		public BreakableGimmick();
		static BreakableGimmick();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction();
		private void SetDrawObject(int id, bool effectFlag);
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
