/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlYinYang : CUGCtrlBase
	{
		// Fields
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
	
		// Properties
		public State state { get; private set; }
		public override bool active { get; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			YinYang = 1,
			Abort = 2,
			Booking = 3
		}
	
		// Constructors
		public CtrlYinYang();
	
		// Methods
		public void Setup(CharacterBase owner, float iconOffsetY);
		public override void ResetState();
		public bool CanStart();
		public void Start(float duration);
		public void ResetTime(float duration);
		public override void Abort();
		public override void Update();
		private void ProcBegin();
		private void ProcAbort();
		private void PlayEffectLocal();
		public override void PlayEffect();
		public override void StopEffect();
		public void DeleteEffect();
		private void SendYinYangEvent(State state);
		public void OnReceiveEvent(CharacterSpecialState recvData);
		private void ProcessReceivedEvent();
	}
}
