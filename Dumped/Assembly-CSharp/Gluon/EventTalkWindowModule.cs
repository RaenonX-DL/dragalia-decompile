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
	public class EventTalkWindowModule : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text charaNameText;
		[SerializeField]
		private UnityEngine.UI.Text contentText;
		[Header]
		[SerializeField]
		public RectTransform rt;
		[Header]
		[SerializeField]
		public AnimationUITalkWindow balloonAnimation;
		public UIAnimationPublisher commonBalloonAnimaiton;
		[Header]
		[SerializeField]
		public Type type;
		[Header]
		[SerializeField]
		public EventStatusInfoCtrl infoCtrl;
		private float contentAnimationSpeed;
	
		// Nested types
		public enum Type
		{
			Balloon = 0,
			TextWindow = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public EventTalkWindowModule __4__this;
			public string voiceData;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _StartCloseAndOpenAnimation_b__0();
		}
	
		// Constructors
		public EventTalkWindowModule();
	
		// Methods
		public void SetCharaName(string charaName);
		public void SetContent(string content);
		public void SetShowHide(bool show);
		public bool IsActiveInHierarchy();
		public void SetShowHideWithScale(bool show);
		public bool IsHidingWithScale();
		public void StartEnterAnimation();
		public void StartExitAnimation();
		public void StartCloseAndOpenAnimation(string voiceData, Action onCloseAndReopen = null);
	}
}
