using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestSkillHolyLightElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _RecastTimeLv1;

		[SerializeField]
		private float _RecastTimeLv2;

		[SerializeField]
		private float _RecastTimeLv3;

		[SerializeField]
		private int _DamageLv1;

		[SerializeField]
		private int _DamageLv2;

		[SerializeField]
		private int _DamageLv3;

		[SerializeField]
		private float _MiasmaReduceLv1;

		[SerializeField]
		private float _MiasmaReduceLv2;

		[SerializeField]
		private float _MiasmaReduceLv3;

		[SerializeField]
		private float _CollisionSizeLv1;

		[SerializeField]
		private float _CollisionSizeLv2;

		[SerializeField]
		private float _CollisionSizeLv3;

		[SerializeField]
		private float _RecastRecoveryByPillarLv1;

		[SerializeField]
		private float _RecastRecoveryByPillarLv2;

		[SerializeField]
		private float _RecastRecoveryByPillarLv3;

		[SerializeField]
		private int _IsCoolTimeRecoveredByTime;

		[SerializeField]
		private float _InvincibleTime;

		[SerializeField]
		private float _HolyLightEffectDelayTime;

		[SerializeField]
		private string _SkillSENameLv1;

		[SerializeField]
		private string _SkillSENameLv2;

		[SerializeField]
		private string _SkillSENameLv3;

		[SerializeField]
		private float _MarkerSize;

		[SerializeField]
		private float _ChargeTime;

		public string Id => null;

		public float RecastTimeLv1 => default(float);

		public float RecastTimeLv2 => default(float);

		public float RecastTimeLv3 => default(float);

		public int DamageLv1 => default(int);

		public int DamageLv2 => default(int);

		public int DamageLv3 => default(int);

		public float MiasmaReduceLv1 => default(float);

		public float MiasmaReduceLv2 => default(float);

		public float MiasmaReduceLv3 => default(float);

		public float CollisionSizeLv1 => default(float);

		public float CollisionSizeLv2 => default(float);

		public float CollisionSizeLv3 => default(float);

		public float RecastRecoveryByPillarLv1 => default(float);

		public float RecastRecoveryByPillarLv2 => default(float);

		public float RecastRecoveryByPillarLv3 => default(float);

		public int IsCoolTimeRecoveredByTime => default(int);

		public float InvincibleTime => default(float);

		public float HolyLightEffectDelayTime => default(float);

		public string SkillSENameLv1 => null;

		public string SkillSENameLv2 => null;

		public string SkillSENameLv3 => null;

		public float MarkerSize => default(float);

		public float ChargeTime => default(float);
	}
}
