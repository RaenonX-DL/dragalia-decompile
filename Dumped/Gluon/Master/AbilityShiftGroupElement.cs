using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AbilityShiftGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AmuletEffectMaxLevel;

		[SerializeField]
		private int _Level1;

		[SerializeField]
		private int _Level2;

		[SerializeField]
		private int _Level3;

		[SerializeField]
		private int _Level4;

		[SerializeField]
		private int _Level5;

		[SerializeField]
		private int _Level6;

		[SerializeField]
		private int _Level7;

		[SerializeField]
		private int _Level8;

		public int Id => default(int);

		public int AmuletEffectMaxLevel => default(int);

		public int Level1 => default(int);

		public int Level2 => default(int);

		public int Level3 => default(int);

		public int Level4 => default(int);

		public int Level5 => default(int);

		public int Level6 => default(int);

		public int Level7 => default(int);

		public int Level8 => default(int);
	}
}
