using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyLevelHitElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _GroupLabel;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private string _HitAttributeIDDefault;

		[SerializeField]
		private string _HitAttributeIDFire;

		[SerializeField]
		private string _HitAttributeIDWater;

		[SerializeField]
		private string _HitAttributeIDWind;

		[SerializeField]
		private string _HitAttributeIDLight;

		[SerializeField]
		private string _HitAttributeIDDark;

		public int Id => default(int);

		public string GroupLabel => null;

		public int Level => default(int);

		public string HitAttributeIDDefault => null;

		public string HitAttributeIDFire => null;

		public string HitAttributeIDWater => null;

		public string HitAttributeIDWind => null;

		public string HitAttributeIDLight => null;

		public string HitAttributeIDDark => null;
	}
}
