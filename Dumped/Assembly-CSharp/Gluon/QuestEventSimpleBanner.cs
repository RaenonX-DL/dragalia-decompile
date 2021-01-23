/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventSimpleBanner : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private PointerEventHandler simpleExchangeButton;
		[SerializeField]
		private PointerEventHandler simpleHowToButton;
		[SerializeField]
		private ButtonWithSelectedImage simpleHowToButtonWithSelected;
		[SerializeField]
		private UnityEngine.UI.Text simpleViewTime;
		[SerializeField]
		private SimpleEventItem[] simpleEventItemRoot;
		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;
		private int eventId;
	
		// Constructors
		public QuestEventSimpleBanner();
	
		// Methods
		public void Initialize(int eventId);
		public void PlayEnterAnimation(Action onFinished, Action onHalfFinished = null);
		public void PlayExitAnimation(Action onFinished, Action onHalfFinished = null);
		public void OnSimpleExchangeButtonClick();
		public void OnSimpleHowToButtonClick();
		[CompilerGenerated]
		private void _OnSimpleHowToButtonClick_b__11_0();
	}
}
