/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Mission.ListView;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionWidgetRemainingTime : MonoBehaviour
	{
		// Fields
		private MissionTableViewData.State state;
		private bool isDrawTime;
		private DateTime end;
		[Header]
		[SerializeField]
		private GameObject clearedTextImage;
		[Header]
		[SerializeField]
		private GameObject clearedStampImage;
		[Header]
		[SerializeField]
		private GameObject receivedTextImage;
		[Header]
		[SerializeField]
		private GameObject receivedStampImage;
		[Header]
		[SerializeField]
		private GameObject goRemainingTime;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text textRemainingTime;
		[Header]
		[SerializeField]
		private Image iconLimit;
		public UnityAction expiredCallback;
	
		// Constructors
		public MissionWidgetRemainingTime();
	
		// Methods
		private void Update();
		public void Initialize(MissionTableViewData.State state);
		public void Initialize(MissionTableViewData.State state, DateTime end);
		public void SetState(MissionTableViewData.State state);
		public void SetDrawTime(bool isDrawTime);
		private string GetTimeText(TimeSpan span);
		public void UpdateTime(TimeSpan span);
		private void SetVisibleClearedImage(bool visible);
		private void SetVisibleReceivedImage(bool visible);
	}
}
