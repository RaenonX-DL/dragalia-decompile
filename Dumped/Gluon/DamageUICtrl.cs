using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DamageUICtrl
	{
		private class TotalDamageData
		{
			private class ActionData
			{
				public int productId
				{
					[CompilerGenerated]
					get
					{
						return default(int);
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public int damage
				{
					[CompilerGenerated]
					get
					{
						return default(int);
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				private ActionData()
				{
				}

				public ActionData(int productId, int damage, bool isHitCountDamage)
				{
				}

				public void Reset()
				{
				}

				public bool AddDamage(int productId, int damage, bool isHitCountDamage)
				{
					return default(bool);
				}
			}

			private Dictionary<int, Dictionary<int, ActionData>> _skillDataList;

			private TotalDamageData()
			{
			}

			public TotalDamageData(int skillId, int actionId, int productId, int damage, bool isHitCountDamage)
			{
			}

			public void Reset(int skillId)
			{
			}

			public void Reset()
			{
			}

			public void AddDamage(int skillId, int actionId, int productId, int damage, bool isHitCountDamage)
			{
			}

			public int GetDamage(int skillId)
			{
				return default(int);
			}

			public bool CheckAliveBullet(CharacterBase chara, int skillId)
			{
				return default(bool);
			}
		}

		private DamageNumUI[] _damageNumUIArray;

		private int _damageNumUIIndex;

		private DamageFigUI[] _damageFigUIArray;

		private int _damageFigUIIndex;

		private bool[] _totalDamageUsedIndexArray;

		private Dictionary<CharacterBase, TotalDamageData> _totalDamageDataDic;

		private const int ReserveNum = 20;

		public void Initialize(GameObject parent, InGameUICtrl inGameUI)
		{
		}

		public void ShowDamageUI(CharacterBase character, int value, Vector3 position, bool isCritical, bool isDragon, DamageNumUI.DamageType damageType, DamageNumUI.Target target, bool isRaid, bool isAttackControlPlayer, bool isTotalDamage, int totalDamageIndex, bool isDebuffExtraDamage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int buffIconId, bool isHitCount)
		{
		}

		public void ShowNoDamageUI(Vector3 position, DamageFigUI.NoDamageType noDamageType, Color color)
		{
		}

		public void ShowRecoverHP(int value, Vector3 position)
		{
		}

		public void ShowRecoverSP(int value, Vector3 position)
		{
		}

		public void StopAllDamageUI()
		{
		}

		public void ShowTotalDamage(CharacterBase character, int skillId)
		{
		}

		public void AddTotalDamage(CharacterBase character, int actionId, int skillId, int actionProductId, int damage, bool isHitCountDamage)
		{
		}

		public void ResetTotalDamage(CharacterBase character, int skillId)
		{
		}

		public void ResetTotalDamageData()
		{
		}
	}
}
