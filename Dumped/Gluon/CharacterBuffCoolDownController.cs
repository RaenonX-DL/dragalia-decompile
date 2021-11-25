using System;
using System.Collections.Generic;

namespace Gluon
{
	public class CharacterBuffCoolDownController
	{
		public class CoolDownData
		{
			public float coolDown;

			public float maxCoolDown;

			public CharacterBase owner;

			public Func<bool> onDelayApply;

			public int buffIconId;

			public float CoolDownRate => default(float);
		}

		public Dictionary<CharacterBuffType, CoolDownData> buffCoolDownDictonary;

		public void SetDelayApply(CharacterBuffType type, CharacterBase owner, int conditionId, float rate, Func<bool> onDelayApply)
		{
		}

		public void RegisterCoolDownForBuff(CharacterBuffType type, float coolDown)
		{
		}

		public void Reset()
		{
		}

		public bool IsCoolingDown(CharacterBuffType type)
		{
			return default(bool);
		}

		public CoolDownData GetCoolingDown(int buffIconId)
		{
			return null;
		}

		public void Update()
		{
		}

		private void UpdateBuffCoolDown(float delta)
		{
		}

		public void RemoveCoolDownForBuffType(CharacterBuffType type)
		{
		}

		public void RemoveAllCoolDownBuffs()
		{
		}
	}
}
