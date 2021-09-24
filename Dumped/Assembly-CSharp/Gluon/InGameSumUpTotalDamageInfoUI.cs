/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameSumUpTotalDamageInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _counterCtrl;
		private float _headerMargin;
	
		// Constructors
		public InGameSumUpTotalDamageInfoUI();
	
		// Methods
		public static InGameSumUpTotalDamageInfoUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public override void FastUpdate();
		public void SetCount(long count);
		public void Visible(bool b);
	}
}
