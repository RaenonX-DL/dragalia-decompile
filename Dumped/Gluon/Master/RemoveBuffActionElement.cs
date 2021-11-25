using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RemoveBuffActionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DragonShift;

		[SerializeField]
		private int _WeaponSkill;

		[SerializeField]
		private int _SupportSkill;

		[SerializeField]
		private int _ShareSkill;

		public int Id => default(int);

		public int DragonShift => default(int);

		public int WeaponSkill => default(int);

		public int SupportSkill => default(int);

		public int ShareSkill => default(int);
	}
}
