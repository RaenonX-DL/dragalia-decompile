using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyListElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _GaugeName;

		[SerializeField]
		private TribeType _TribeType;

		[SerializeField]
		private int _Register;

		[SerializeField]
		private int _SortKey;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private int _MaxCount;

		[SerializeField]
		private float _BossAppearMotionStartTime;

		[SerializeField]
		private float _BossAppearTime;

		[SerializeField]
		private float _BossAppearCameraAnimationCutTime;

		[SerializeField]
		private float _BossScale;

		[SerializeField]
		private Gluon.BossCamera _BossCameraType;

		[SerializeField]
		private string _BossBlurEffect;

		public int Id => default(int);

		public string Name => null;

		public string GaugeName => null;

		public TribeType TribeType => default(TribeType);

		public int Register => default(int);

		public int SortKey => default(int);

		public int Rarity => default(int);

		public int MaxCount => default(int);

		public float BossAppearMotionStartTime => default(float);

		public float BossAppearTime => default(float);

		public float BossAppearCameraAnimationCutTime => default(float);

		public float BossScale => default(float);

		public Gluon.BossCamera BossCameraType => default(Gluon.BossCamera);

		public string BossBlurEffect => null;
	}
}
