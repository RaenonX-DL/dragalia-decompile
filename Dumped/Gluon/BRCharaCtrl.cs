using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class BRCharaCtrl
	{
		private PlayerCharacter owner;

		private int brUnitId;

		private int weaponGlowItemNum;

		private int maxWeaponLevel;

		public bool isBot;

		private bool needsRecoveryDp;

		public int killCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BRCharaCtrl(PlayerCharacter owner)
		{
		}

		public void Update()
		{
		}

		public void AddWeaponGlowItem(int value)
		{
		}

		private void SetWeaponGlowItem(int value, bool needSync)
		{
		}

		public void OnReceiveWeaponGlow(CharacterSpecialState recvData)
		{
		}

		public void OnReceiveAbilityItem(CharacterSpecialState recvData)
		{
		}

		public int GetWeaponLevel()
		{
			return default(int);
		}

		public bool IsWeaponLevelMax()
		{
			return default(bool);
		}

		public int GetWeaponGlowItemNum()
		{
			return default(int);
		}

		public int GetWeaponGlowItemNextNum(int level)
		{
			return default(int);
		}

		public float GetAttackRatio()
		{
			return default(float);
		}

		public BattleRoyalUnitElement GetBRUnitElem()
		{
			return null;
		}

		public void AddAbilityItem(AbilityDataElement ade)
		{
		}

		public static string GetPlayerName(CharacterBase chara)
		{
			return null;
		}

		public void SendLevelUp(int level)
		{
		}
	}
}
