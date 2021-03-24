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
	public class EventInfoCtrlBase : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Button howtoButton;
		[Header]
		[SerializeField]
		public Button scheduleButton;
		[Header]
		[SerializeField]
		public UIAnimationPublisher innerMovePublisher;
		[Header]
		[SerializeField]
		public RectTransform syncTopMask;
	
		// Constructors
		public EventInfoCtrlBase();
	
		// Methods
		protected virtual void Start();
		public virtual void SetEventInfo();
		public virtual void OnResetTopImageAndTalk();
		public void OnHowtoButtonTouched();
		public void OnScheduleButtonTouched();
		protected virtual void ResetSpecialHelpButtonPressedState();
		public void AdjustMoveOffset(float moveOffset);
		[CompilerGenerated]
		private void _OnHowtoButtonTouched_b__7_0();
		[CompilerGenerated]
		private void _OnScheduleButtonTouched_b__8_0();
	}
}
