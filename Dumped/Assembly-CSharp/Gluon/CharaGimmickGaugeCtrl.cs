/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickGaugeCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _gaugeRt;
		private Dictionary<CharacterBase, CharaGimmickBaseGaugeUI> _gaugeList;
	
		// Nested types
		public enum GaugeType
		{
			None = 0,
			ActiveGauge = 1,
			ModeGauge = 2,
			OverflowGauge = 3,
			OverflowGauge2 = 4,
			CustomPointGauge = 5,
			CustomPointGauge2 = 6,
			GunChargeGauge = 7
		}
	
		[CompilerGenerated]
		private sealed class _SetGaugeValue_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public CharaGimmickBaseGaugeUI gauge;
			public int idx;
			public int value;
			public int consumeValue;
			public int maxValue;
			public bool isImmediateGaugeAnim;
			public bool isPlayAnim;
			public bool isSkipGaugePrevWaitTime;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetGaugeValue_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CharaGimmickGaugeCtrl();
	
		// Methods
		public static CharaGimmickGaugeCtrl Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public override void FastUpdate();
		public void Attach(CharacterBase chara, GaugeType type);
		public void Show(CharacterBase chara);
		public void SetGaugeValue(CharacterBase chara, int idx, int value, int consumeValue, int maxValue, float delay, bool isImmediateGaugeAnim, bool isPlayAnim, bool isSkipGaugePrevWaitTime);
		[IteratorStateMachine]
		private IEnumerator SetGaugeValue(CharaGimmickBaseGaugeUI gauge, int idx, int value, int consumeValue, int maxValue, float delay, bool isImmediateGaugeAnim, bool isPlayAnim, bool isSkipGaugePrevWaitTime);
		public void SetMode(CharacterBase chara, int mode);
		public void SetGaugeAnimCompleteCallback(CharacterBase chara, int idx, Action<int> onComplete);
		public void SetGaugeAnimCompleteCallback(CharacterBase chara, int idx, Action<int, int, int> onComplete);
		public float GetGaugeMoveTime(CharacterBase chara);
		public void ChangeAppearance(CharacterBase chara, int type);
		public void SetAbilityData(CharacterBase chara, ref List<AbilityDataElement> list);
	}
}
