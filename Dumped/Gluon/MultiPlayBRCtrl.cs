using System.Runtime.CompilerServices;
using Gluon.Event;

namespace Gluon
{
	public class MultiPlayBRCtrl
	{
		private MultiPlayReceiveEventBuffering _recvEventBuffering;

		private BRPulse _brPulse;

		private bool _isInitWorldRequested;

		private static readonly float _extraParamSendIntervalTime;

		private float _extraParamSendDelayTimer;

		public bool IsBRTutorial
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Update()
		{
		}

		public void OnReceiveBREvent(BRCreateItemEvent recvEvent)
		{
		}

		private bool TryReceiveBREvent(BRGetItemEvent recvEvent)
		{
			return default(bool);
		}

		public void OnReceiveBREvent(BRGetItemEvent recvEvent)
		{
		}

		public void OnReceiveBREvent(BRInitWorld recvEvent)
		{
		}

		public bool OnReceiveGameStep(GameStepEvent.StepTypes step)
		{
			return default(bool);
		}

		public void SetBRPulse(BRPulse pulse)
		{
		}

		public void OnReceiveBREvent(BRNotifyEvent recvEvent)
		{
		}

		private void CheckInitWorld()
		{
		}

		private void SendExtraParam()
		{
		}
	}
}
