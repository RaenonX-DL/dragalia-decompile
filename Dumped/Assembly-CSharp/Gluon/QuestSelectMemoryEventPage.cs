/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectMemoryEventPage : QuestSelectEventPageBase, ICustomMessage
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject activeEventGO;
		public SimpleAnimationCell activeTitleAnimationCell;
		public QuestMenuMemoryEventBanner activeBanner;
		[Header]
		[SerializeField]
		public QuestMenuMemoryEventBanner templateBanner;
		[Header]
		[SerializeField]
		public GameObject recommendedGO;
		public SimpleAnimationCell recommendedTitleAnimationCell;
		public Transform recommendedParent;
		[Header]
		[SerializeField]
		public GameObject othersGO;
		public SimpleAnimationCell otherTitleAnimationCell;
		public Transform othersParent;
		[Header]
		[SerializeField]
		public UIAnimationPublisher publisher;
		[Header]
		[SerializeField]
		public ButtonWithSelectedImage howtoButtonWithSelectedImage;
		private QuestSelectInstance.QuestEventData eventData;
		private const string prefMemoryTutorial = "__MemoryEventTutorialPU";
		private Dictionary<int, float> scrollValueDic;
		private const int tutorialPageCount = 2;
	
		// Constructors
		public QuestSelectMemoryEventPage();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		private void Start();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1);
		private void CreateEventList(QuestSelectInstance.QuestEventData eventData);
		public void OnBackButtonTouched();
		public void OnHowToButtonPressed();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _OnHowToButtonPressed_b__26_0();
	}
}
