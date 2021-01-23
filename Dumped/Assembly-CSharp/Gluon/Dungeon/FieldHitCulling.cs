/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FieldHitCulling : GimmickBase
	{
		// Fields
		[SerializeField]
		private Transform cullTargetTransform;
		private List<Renderer> cullTargetRendererList;
		private List<Material> cullTargetMaterialList;
		[SerializeField]
		private Transform removeForWinProductionTransform;
		private bool burnFlag;
		[SerializeField]
		private List<Transform> removeForFireBallTransformList;
		[SerializeField]
		private List<Transform> appearForFireBallTransformList;
		[SerializeField]
		private float inFadeTime;
		private static readonly float inFadeValue;
		[SerializeField]
		private float outFadeTime;
		private static readonly float outFadeValue;
		private List<BRItemBase> brItemBaseList;
		private Collider hitCollider;
		private Coroutine _progressCoroutine;
		private HashSet<CharacterBase> insideCharas;
		private CharacterBase prevFocusChara;
	
		// Properties
		protected virtual Coroutine progressCoroutine { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _TransitionAlpha_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FieldHitCulling __4__this;
			public float maxSec;
			public bool inFlag;
			private float _nowSec_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _TransitionAlpha_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FieldHitCulling();
		static FieldHitCulling();
	
		// Methods
		public void SetBurn(string label, int triggerId);
		protected override void Awake();
		public override void FastUpdate();
		private void UpdateItem(bool insideWithPlayer);
		private bool IsFadeOK(CharacterBase chara);
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		protected virtual void StartFadeIn();
		protected virtual void StartFadeOut();
		protected void StartFadeCoroutine(bool inFlag, float fadeValue, float fadeTime);
		[IteratorStateMachine]
		private IEnumerator TransitionAlpha(bool inFlag, float toValue, float maxSec);
		private void ChangeEffectAlpha(float alpha);
		private bool IsCameraFocusCharaInside();
		private void SetCharaVisibility(CharacterBase chara, bool visibility, bool force);
		public override void OnProductionTime();
	}
}
