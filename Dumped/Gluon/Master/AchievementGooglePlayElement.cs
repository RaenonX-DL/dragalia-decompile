using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AchievementGooglePlayElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _PlatformAchievementId;

		public int Id => default(int);

		public string PlatformAchievementId => null;
	}
}
