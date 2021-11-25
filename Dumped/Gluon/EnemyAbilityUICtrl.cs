using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class EnemyAbilityUICtrl : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private RectTransform _rootRt;

		[SerializeField]
		private RectTransform _iconRt;

		private Dictionary<string, Material> _iconList;

		private List<EnemyAbilityUI> _abilityList;

		private InGameFollowLayout _followLayout;

		private const int DefaultIconNum = 4;

		public static EnemyAbilityUICtrl Create(GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(GameObject prefab)
		{
		}

		private void OnDestroy()
		{
		}

		public void Update()
		{
		}

		public void EntryEnemyAbility(List<EnemyAbilityProcBase> abilities)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		private void Visible(bool b, bool force = false)
		{
		}

		public void SetEnemyAbility(List<EnemyAbilityProcBase> abilities)
		{
		}

		private bool GetCount(EnemyAbilityProcBase ability, out int count)
		{
			return default(bool);
		}

		public void EnableEnmeyAbility(int id)
		{
		}

		public void DisableEnmeyAbility(int id)
		{
		}

		public EnemyAbilityUI GetEnmeyAbility(int id)
		{
			return null;
		}

		private void ApplyIconPosition()
		{
		}

		public Material GetEnemyAbilityIcon(string iconId)
		{
			return null;
		}
	}
}
