/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultEarnEventBonusCell : SimpleAnimationCell
	{
		// Fields
		[SerializeField]
		private RawImage icon;
		[SerializeField]
		private Image medalIcon;
		[SerializeField]
		private UnityEngine.UI.Text ptValueText;
		[SerializeField]
		private UnityEngine.UI.Text koValueText;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private Image effectImage;
		private bool isCancelled;
		private const float moveBackDis = 20f;
		public Action checkLabelAction;
		private const string seCheckMark = "SE_OUT_RANDOM_003";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__12_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowStartAnimation_b__12_1();
		}
	
		// Constructors
		public QuestResultEarnEventBonusCell();
	
		// Methods
		protected override void Awake();
		public void SetContent(QuestResultModel.ScoringEnemyPointListData.EnemyPointListData data);
		public void ShowStartAnimation();
		public void CancelAnimation();
		private void CancelAnimationImpl();
		[CompilerGenerated]
		private void _ShowStartAnimation_b__12_0();
		[CompilerGenerated]
		private void _ShowStartAnimation_b__12_5();
		[CompilerGenerated]
		private void _ShowStartAnimation_b__12_2();
		[CompilerGenerated]
		private void _ShowStartAnimation_b__12_3();
		[CompilerGenerated]
		private void _ShowStartAnimation_b__12_4();
	}
}
