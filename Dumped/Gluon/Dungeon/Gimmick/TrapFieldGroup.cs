using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class TrapFieldGroup : MonoBehaviour
	{
		private class VictimInfo
		{
			public CharacterBase chara;

			public CharacterSelector charaSelector;

			public int enterCount;

			public float hitTimer;

			public CollisionHitAttribute hitAttribute;

			public AbnormalStatusType abs;

			public bool resist;
		}

		private List<TrapField> fields;

		private Dictionary<int, VictimInfo> victimInfoDic;

		private const float HIT_INTERVAL_SEC = 3f;

		private bool colliderEnabled;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private int GetInstanceID(GameObject go)
		{
			return default(int);
		}

		private bool IsExitStateCharacter(CharacterSelector charaSelector)
		{
			return default(bool);
		}

		private bool IsSupportRequestCharacter(CharacterSelector charaSelector)
		{
			return default(bool);
		}

		private void OnEnterField(TrapField field, Collider other)
		{
		}

		private void OnExitField(TrapField field, Collider other)
		{
		}
	}
}
