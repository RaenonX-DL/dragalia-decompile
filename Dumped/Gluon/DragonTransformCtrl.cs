using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DragonTransformCtrl : MonoBehaviour
	{
		public enum State
		{
			None,
			Start,
			End
		}

		public enum TransformType
		{
			None,
			Dragon,
			Unique,
			Servant
		}

		private TransformType transformType;

		private PlayerCtrl player;

		private float elapsedTime;

		public static readonly float forceChangeSec;

		private List<CharacterBase> transformNgCharaList;

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetTransformNgChara(CharacterBase chara, bool ngFlag)
		{
		}

		public bool CheckTransformNgChara(CharacterBase chara)
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetPlayer(PlayerCtrl player)
		{
		}

		public void StartActive(PlayerCtrl player, TransformType type, bool isSkipProduction = false)
		{
		}

		public void SetStateEnd()
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}
	}
}
