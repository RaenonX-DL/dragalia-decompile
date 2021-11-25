using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class FishingPowerData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _redFishingPower;

		[SerializeField]
		[HideInInspector]
		private int _goldFishingPower;

		[SerializeField]
		[HideInInspector]
		private int _yakiFishingPower;

		public int redFishingPower => default(int);

		public int goldFishingPower => default(int);

		public int yakiFishingPower => default(int);
	}
}
