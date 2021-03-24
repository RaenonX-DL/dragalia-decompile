/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestAgitoBanner : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;
		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;
		private QuestEventGroupElement groupElement;
	
		// Constructors
		public QuestAgitoBanner();
	
		// Methods
		public void Initialize(QuestEventGroupElement element);
		public void PlayEnterAnimation(Action onFinished, Action onHalfFinished = null);
		public void PlayExitAnimation(Action onFinished, Action onHalfFinished = null);
		public void OnQuestDetail();
		[CompilerGenerated]
		private void _OnQuestDetail_b__6_0();
	}
}
