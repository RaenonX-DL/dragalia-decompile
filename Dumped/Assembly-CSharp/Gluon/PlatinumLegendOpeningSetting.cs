/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class PlatinumLegendOpeningSetting : ScriptableObject
	{
		// Fields
		public ShowPickup[] showPickup;
		public PeriodCaptionType[] periodCaptionType;
		[HideInInspector]
		public SummonGroupElement summonGroup;
		private const int showPickupNum = 3;
	
		// Nested types
		public enum PeriodCaptionType
		{
			None = -1,
			Chara = 0,
			Dragon = 1,
			Amulet = 2
		}
	
		[Serializable]
		public class ShowPickup
		{
			// Fields
			public Material material;
			public Vector2 offset;
	
			// Constructors
			public ShowPickup();
		}
	
		// Constructors
		public PlatinumLegendOpeningSetting();
	
		// Methods
		public static string GetPeriodCaption(PeriodCaptionType type);
	}
}
