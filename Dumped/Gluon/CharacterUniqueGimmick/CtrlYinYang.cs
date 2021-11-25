using System.Collections.Generic;
using Gluon.Event;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlYinYang : CUGCtrlBase
	{
		public enum State
		{
			Idle,
			YinYang,
			Abort,
			Booking
		}

		private State _state;

		private float _duration;

		private float _timer;

		public const string YINYANG_EFFECT_NAME = "EFF_BOS_HBS_0030401_014";

		private EffectObject _eoIcon;

		private const int EFF_TRIG_YIN = 9;

		private const int EFF_TRIG_YANG = 8;

		private float _iconOffsetY;

		private List<CharacterSpecialState> _recvEventList;

		private bool _isAbortReserved;

		public State state
		{
			get
			{
				return default(State);
			}
			private set
			{
			}
		}

		public override bool active => default(bool);

		public void Setup(CharacterBase owner, float iconOffsetY)
		{
		}

		public override void ResetState()
		{
		}

		public bool CanStart()
		{
			return default(bool);
		}

		public void Start(float duration)
		{
		}

		public void ResetTime(float duration)
		{
		}

		public override void Abort()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private void ProcBegin()
		{
		}

		private void ProcAbort()
		{
		}

		private void PlayEffectLocal()
		{
		}

		public override void PlayEffect()
		{
		}

		public override void StopEffect()
		{
		}

		public void DeleteEffect()
		{
		}

		private void SendYinYangEvent(State state)
		{
		}

		public void OnReceiveEvent(CharacterSpecialState recvData)
		{
		}

		private void ProcessReceivedEvent()
		{
		}
	}
}
