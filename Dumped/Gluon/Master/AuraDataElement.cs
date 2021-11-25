using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AuraDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private AuraType _Type;

		[SerializeField]
		private int _PublishLevel;

		[SerializeField]
		private float _DurationExtension;

		[SerializeField]
		private float _Rate01;

		[SerializeField]
		private float _Duration01;

		[SerializeField]
		private float _Rate02;

		[SerializeField]
		private float _Duration02;

		[SerializeField]
		private float _Rate03;

		[SerializeField]
		private float _Duration03;

		[SerializeField]
		private float _Rate04;

		[SerializeField]
		private float _Duration04;

		[SerializeField]
		private float _Rate05;

		[SerializeField]
		private float _Duration05;

		[SerializeField]
		private float _Rate06;

		[SerializeField]
		private float _Duration06;

		public int Id => default(int);

		public AuraType Type => default(AuraType);

		public int PublishLevel => default(int);

		public float DurationExtension => default(float);

		public float Rate01 => default(float);

		public float Duration01 => default(float);

		public float Rate02 => default(float);

		public float Duration02 => default(float);

		public float Rate03 => default(float);

		public float Duration03 => default(float);

		public float Rate04 => default(float);

		public float Duration04 => default(float);

		public float Rate05 => default(float);

		public float Duration05 => default(float);

		public float Rate06 => default(float);

		public float Duration06 => default(float);
	}
}
