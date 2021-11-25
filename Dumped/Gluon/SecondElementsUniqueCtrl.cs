using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class SecondElementsUniqueCtrl : EnemyUniqueCtrl
	{
		public enum ElementType
		{
			Curse = 0,
			Bless = 1,
			Wind = 2,
			Fire = 3,
			None = 99
		}

		public enum State
		{
			Init,
			Idle,
			Running,
			Groggy,
			Regain
		}

		public static readonly int SECOUND_ELEMENTS_NUM;

		private float[] _origin;

		private float[] _limit;

		[SerializeField]
		private float[] _point;

		[SerializeField]
		private float[] _power;

		private ElementType _selectedElement;

		[SerializeField]
		private State _state;

		private int _actionId;

		public override void Initialize()
		{
		}

		public void Setup(Setup2ndElementsData resource)
		{
		}

		public void OnStart()
		{
		}

		public override void FastUpdate()
		{
		}

		private void Ready()
		{
		}

		public void OnDamage(CollisionHitAttribute hitAttr, int damage)
		{
		}

		public bool CheckGroggy()
		{
			return default(bool);
		}

		public bool Regain()
		{
			return default(bool);
		}

		public bool IsValidElement(ElementType element)
		{
			return default(bool);
		}

		public bool IsValidAnyElement()
		{
			return default(bool);
		}

		public void SetCurrentPoint(ElementType element, float value)
		{
		}

		public void SubCurrentPoint(ElementType element, float value)
		{
		}

		public float GetCurrentPoint(ElementType element)
		{
			return default(float);
		}

		public void SetLimitPoint(ElementType element, float value)
		{
		}

		public float GetLimitPoint(ElementType element)
		{
			return default(float);
		}

		public float GetRate(ElementType element)
		{
			return default(float);
		}

		public void ShowSecondElementsGaugeUI()
		{
		}

		public void SendGroggy(ElementType element)
		{
		}

		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent)
		{
		}

		public override void OnChangeState(CharacterState state)
		{
		}
	}
}
