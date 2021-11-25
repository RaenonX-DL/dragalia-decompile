using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class StackBuffDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _LimitNum;

		[SerializeField]
		private BuffType _BuffType1;

		[SerializeField]
		private float _Rate1;

		[SerializeField]
		private BuffType _BuffType2;

		[SerializeField]
		private float _Rate2;

		[SerializeField]
		private BuffType _BuffType3;

		[SerializeField]
		private float _Rate3;

		public int Id => default(int);

		public int LimitNum => default(int);

		public BuffType BuffType1 => default(BuffType);

		public float Rate1 => default(float);

		public BuffType BuffType2 => default(BuffType);

		public float Rate2 => default(float);

		public BuffType BuffType3 => default(BuffType);

		public float Rate3 => default(float);
	}
}
