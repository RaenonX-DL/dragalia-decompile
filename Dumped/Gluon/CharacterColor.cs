using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class CharacterColor
	{
		public enum State
		{
			None,
			Reset,
			Smooth,
			FromDragon,
			Curse,
			Frostbite,
			Poison,
			Burn,
			Paralysis,
			Flashheat,
			Darkabs,
			Crashwind,
			Destroyfire,
			Darkness,
			SlowMove,
			Freeze,
			Swoon,
			Sleep,
			Break,
			DamageParts,
			DamagePartsDragon,
			Damage,
			DamageDragon,
			HealSp,
			HealHp,
			Invincible
		}

		private class Process
		{
			public enum Phase
			{
				ToSetColor = 0,
				ToOriginalColor = 1,
				Idle = -1
			}

			public State state;

			public float elapsedTime;

			public Phase phase;

			public ColorParam fromBaseParam;

			public ColorParam fromRimParam;

			public ColorParam fromCoverParam;

			public ColorParam toBaseParam;

			public ColorParam toRimParam;

			public ColorParam toCoverParam;

			public void Copy(Process currProcess)
			{
			}

			public void SetFromParam(ColorParam baseParam, ColorParam rimParam, ColorParam coverParam)
			{
			}

			public void SetToParam(ColorParam baseParam, ColorParam rimParam, ColorParam coverParam)
			{
			}

			public void SetToParam(MainGameGraphic.StatusColorParam colorParam)
			{
			}
		}

		private static readonly ColorParam _baseColorDefault;

		private static readonly ColorParam _rimColorDefault;

		private static readonly ColorParam _coverColorDefault;

		public ColorParam smoothColorParam;

		private Process currProcess;

		private Process prevProcess;

		private Process tempProcess;

		private float smoothSec;

		private List<State> stateExecList;

		public ColorParam baseColorParam
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

		public ColorParam rimColorParam
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

		public ColorParam coverColorParam
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

		public void Initialize(CharacterBase chara)
		{
		}

		public void Clear()
		{
		}

		private void SetDefault()
		{
		}

		public void SetState(State state)
		{
		}

		public bool IsRimDamageState()
		{
			return default(bool);
		}

		private void ChangeState(State state)
		{
		}

		public void FinishState(State state)
		{
		}

		public void SetSmooth(ColorParam toBasicColor, float smoothSec)
		{
		}

		public void Update()
		{
		}

		private bool UpdateReset()
		{
			return default(bool);
		}

		private bool UpdateSmooth()
		{
			return default(bool);
		}

		private bool UpdateNoColor()
		{
			return default(bool);
		}

		private bool UpdateColor()
		{
			return default(bool);
		}

		private bool UpdateBreak()
		{
			return default(bool);
		}

		private bool UpdateOneshot(float forwardSec, float reverseSec)
		{
			return default(bool);
		}

		private bool UpdateLoop(float forwardSec, float reverseSec)
		{
			return default(bool);
		}

		private bool UpdateAbnormalStatus(float forwardSec)
		{
			return default(bool);
		}

		private float PlayForward(float sec)
		{
			return default(float);
		}

		private float PlayReverse(float sec)
		{
			return default(float);
		}

		public bool IsActive()
		{
			return default(bool);
		}
	}
}
