using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyHitDifficultyElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _HitAttrIdNormal;

		[SerializeField]
		private string _HitAttrIdHard;

		[SerializeField]
		private string _HitAttrIdVeryhard;

		[SerializeField]
		private string _HitAttrIdExtreme;

		[SerializeField]
		private string _HitAttrIdHell;

		[SerializeField]
		private string _HitAttrId6;

		[SerializeField]
		private string _HitAttrId7;

		[SerializeField]
		private string _HitAttrId8;

		[SerializeField]
		private string _HitAttrId9;

		[SerializeField]
		private string _HitAttrId10;

		public string Id => null;

		public string HitAttrIdNormal => null;

		public string HitAttrIdHard => null;

		public string HitAttrIdVeryhard => null;

		public string HitAttrIdExtreme => null;

		public string HitAttrIdHell => null;

		public string HitAttrId6 => null;

		public string HitAttrId7 => null;

		public string HitAttrId8 => null;

		public string HitAttrId9 => null;

		public string HitAttrId10 => null;
	}
}
