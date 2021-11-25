using System;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class PlatinumLegendOpeningSetting : ScriptableObject
	{
		public enum PeriodCaptionType
		{
			None = -1,
			Chara,
			Dragon,
			Amulet
		}

		[Serializable]
		public class ShowPickup
		{
			public Material material;

			public Vector2 offset;
		}

		public ShowPickup[] showPickup;

		public PeriodCaptionType[] periodCaptionType;

		[HideInInspector]
		public SummonGroupElement summonGroup;

		private const int showPickupNum = 3;

		public static string GetPeriodCaption(PeriodCaptionType type)
		{
			return null;
		}
	}
}
