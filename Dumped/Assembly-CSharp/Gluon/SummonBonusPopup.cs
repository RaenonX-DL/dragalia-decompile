/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonBonusPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private GameObject[] titleNode;
		[SerializeField]
		private UnityEngine.UI.Text[] titleText;
		[SerializeField]
		private GameObject[] iconNode;
		[SerializeField]
		private RectTransform content;
		private float height;
		private static readonly string path;
		private const float defaultHeight = 766f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Sizefit_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonBonusPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Sizefit_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SummonBonusPopup();
		static SummonBonusPopup();
	
		// Methods
		public static SummonBonusPopup Create(List<SummonResultPrize> itemDataList);
		public void Init(List<SummonResultPrize> summonResultPrizeList);
		[IteratorStateMachine]
		private IEnumerator Sizefit();
		private void SetText(int bonusRarity, int count);
		private void SetIcon(int bonusRarity, SummonPrizeData data);
		public Dictionary<int, List<SummonPrizeData>> GetPutPrizeList(List<SummonResultPrize> summonResultPrizeList);
	}
}
