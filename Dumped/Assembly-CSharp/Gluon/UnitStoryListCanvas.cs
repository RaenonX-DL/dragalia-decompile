/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitStoryListCanvas : AnimationUICanvas
	{
		// Fields
		public UnitStoryListScene scene;
		[SerializeField]
		public Canvas uiCanvas;
		[SerializeField]
		private RectTransform frameRect;
		[SerializeField]
		private TabBase typeTab;
		[SerializeField]
		public Badge[] unreadBadge;
		[SerializeField]
		private TabBase readTab;
		[SerializeField]
		public UnitStoryListController baseListController;
		[SerializeField]
		private GameObject sortButtonRoot;
		[SerializeField]
		public GameObject castleObjRoot;
		[SerializeField]
		public Image triggerItemImage;
		[SerializeField]
		public UnityEngine.UI.Text triggerItemNumText;
		[SerializeField]
		public Image sampleBannerImage;
		private const float reduceFrameAreaHeightForSample = 180f;
	
		// Constructors
		public UnitStoryListCanvas();
	
		// Methods
		protected override void Awake();
		public void InitCanvas();
		public void OnSortButtonPressed();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[CompilerGenerated]
		private void _InitCanvas_b__14_0(int index);
		[CompilerGenerated]
		private void _InitCanvas_b__14_1(int tabIndex, TutorialUIManager.LockButtonType lockType);
		[CompilerGenerated]
		private void _InitCanvas_b__14_2(int index);
	}
}
