using System.Runtime.CompilerServices;
using Cute.Core;

namespace Gluon
{
	public class BotBRTutorialCtrl : FastUpdateMonoBehaviour
	{
		public enum MessageEventType
		{
			None,
			QuestStart,
			KillEnemy_1,
			ActivatUnitSkill,
			ActivatItemSkill,
			PickupUpgrade,
			PickupItemSkill,
			HideGrass
		}

		private class MessageData
		{
			public bool isPlayed;

			public MessageEventType EventType
			{
				[CompilerGenerated]
				get
				{
					return default(MessageEventType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float Time
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool IsCheckTime
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string Message
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public MessageData(MessageEventType eventType, string message)
			{
			}

			public MessageData(MessageEventType eventType, float time, string message)
			{
			}
		}

		private MessageData[] _messageList;

		private float _playTime;

		private bool _isFinishedTimetableMessage;

		public const int EnemyBookID_1 = 100070301;

		public const float SystemMessageDisplayTime = 4f;

		private void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		public void ResetMessage()
		{
		}

		private void PlayTimetableMessage(ref MessageData data, out bool isPlayed)
		{
		}

		private void PlayEventMessage(ref MessageData data, MessageEventType eventType, out bool isPlayed)
		{
		}

		public void OnTutorialEvent(MessageEventType eventType)
		{
		}
	}
}
