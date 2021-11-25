using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyParamPatternElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _PatternName;

		[SerializeField]
		private int _Pattern1;

		[SerializeField]
		private int _Pattern2;

		[SerializeField]
		private int _Pattern3;

		[SerializeField]
		private int _Pattern4;

		[SerializeField]
		private int _Pattern5;

		[SerializeField]
		private int _Pattern6;

		public int Id => default(int);

		public string PatternName => null;

		public int Pattern1 => default(int);

		public int Pattern2 => default(int);

		public int Pattern3 => default(int);

		public int Pattern4 => default(int);

		public int Pattern5 => default(int);

		public int Pattern6 => default(int);
	}
}
