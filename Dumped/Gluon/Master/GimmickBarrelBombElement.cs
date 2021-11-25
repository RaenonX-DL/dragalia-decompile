using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickBarrelBombElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private int _Attack;

		[SerializeField]
		private int _RateDamage;

		[SerializeField]
		private float _BlastHeight;

		[SerializeField]
		private float _BlastAngle;

		[SerializeField]
		private float _BlastGravity;

		[SerializeField]
		private float _ExplosionRange;

		[SerializeField]
		private float _InstallationTime;

		public string Id => null;

		public int Attack => default(int);

		public int RateDamage => default(int);

		public float BlastHeight => default(float);

		public float BlastAngle => default(float);

		public float BlastGravity => default(float);

		public float ExplosionRange => default(float);

		public float InstallationTime => default(float);
	}
}
