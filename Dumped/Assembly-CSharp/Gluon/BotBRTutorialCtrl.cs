/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BotBRTutorialCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		private MessageData[] _messageList;
		private float _playTime;
		private bool _isFinishedTimetableMessage;
		public const int EnemyBookID_1 = 100070301;
		public const float SystemMessageDisplayTime = 4f;
	
		// Nested types
		public enum MessageEventType
		{
			None = 0,
			QuestStart = 1,
			KillEnemy_1 = 2,
			ActivatUnitSkill = 3,
			ActivatItemSkill = 4,
			PickupUpgrade = 5,
			PickupItemSkill = 6,
			HideGrass = 7
		}
	
		private class MessageData
		{
			// Fields
			[CompilerGenerated]
			private MessageEventType _EventType_k__BackingField;
			[CompilerGenerated]
			private float _Time_k__BackingField;
			[CompilerGenerated]
			private bool _IsCheckTime_k__BackingField;
			[CompilerGenerated]
			private string _Message_k__BackingField;
			public bool isPlayed;
	
			// Properties
			public MessageEventType EventType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float Time { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsCheckTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string Message { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public MessageData(MessageEventType eventType, string message);
			public MessageData(MessageEventType eventType, float time, string message);
		}
	
		// Constructors
		public BotBRTutorialCtrl();
	
		// Methods
		private void Awake();
		public override void FastUpdate();
		public void ResetMessage();
		private void PlayTimetableMessage(ref MessageData data, out bool isPlayed);
		private void PlayEventMessage(ref MessageData data, MessageEventType eventType, out bool isPlayed);
		public void OnTutorialEvent(MessageEventType eventType);
	}
}
