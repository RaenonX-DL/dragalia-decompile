/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectAreaPage : QuestSelectPageBase
	{
		// Fields
		[CompilerGenerated]
		private bool _isInitialized_k__BackingField;
		private Canvas _selfCanvas;
	
		// Properties
		public QuestSelectAreaCanvas selectAreaCanvas { get; }
		public bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Canvas selfCanvas { get; set; }
	
		// Constructors
		public QuestSelectAreaPage();
	
		// Methods
		protected override void Awake();
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		public void OnClickBack();
		[CompilerGenerated]
		private void _StartExitAnimation_b__14_0();
	}
}
