using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class TargetEffectCtrl
	{
		public enum TargetType
		{
			None,
			AllyHpRateLowest
		}

		private PlayerCharacter owner;

		private EffectObject effObj;

		private Vector3 startPoint;

		private Vector3 relayPoint;

		private Vector3 endPoint;

		private float elapsedTime;

		private float durationTime;

		private float range;

		private float topOffset;

		private TargetType targetType;

		public CharacterBase target
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

		public TargetEffectCtrl(PlayerCharacter player)
		{
		}

		private void Clear()
		{
		}

		public void ResetTarget()
		{
		}

		public void Setup(TargetEffectData partsData)
		{
		}

		public void Start()
		{
		}

		public void Update()
		{
		}

		private Vector3 CalcPoint(float step)
		{
			return default(Vector3);
		}

		private CharacterBase FindTargetCharacter()
		{
			return null;
		}
	}
}
