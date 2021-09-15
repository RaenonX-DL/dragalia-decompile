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
	public class SummonUpdatedCanvas : AnimationUICanvas
	{
		// Fields
		public SummonUpdatedScene scene;
		public Button skipButton;
		public GameObject movieParent;
		public RectTransform movieViewRect;
		public Tweener showWindowTween;
		public RectTransform periodWindowRootRect;
		[SerializeField]
		private GameObject tapToNextItem;
		[SerializeField]
		private CanvasGroup periodWindowGroup;
		[SerializeField]
		private UnityEngine.UI.Text periodMainCaptionText;
		[SerializeField]
		private UnityEngine.UI.Text periodInfoText;
		[SerializeField]
		private GameObject[] periodLayoutObj;
		[SerializeField]
		private UnityEngine.UI.Text[] periodCaptionText;
		[SerializeField]
		private UnityEngine.UI.Text[] periodText;
		[SerializeField]
		private Vector2 periodWindowInitPos;
		private Vector2 periodWindowTargetPos;
		private readonly Vector2 swingingBackValue;
		private Sequence tapTween;
	
		// Constructors
		public SummonUpdatedCanvas();
	
		// Methods
		private void Start();
		public void OnSkipButtonPressed();
		public void EnableTapToNext(bool enable);
		public void SetPeriodWindowText(PlatinumLegendOpeningSetting setting);
		public void ShowPeriodWindow();
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _ShowPeriodWindow_b__21_0(float value);
		[CompilerGenerated]
		private void _ShowPeriodWindow_b__21_1();
		[CompilerGenerated]
		private void _ShowPeriodWindow_b__21_2(float value);
		[CompilerGenerated]
		private void _ShowPeriodWindow_b__21_3();
	}
}
