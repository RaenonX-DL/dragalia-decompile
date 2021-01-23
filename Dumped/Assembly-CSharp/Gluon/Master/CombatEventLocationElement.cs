/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CombatEventLocationElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private int _LocationRewardId;
		[SerializeField]
		private string _LocationName;
		[SerializeField]
		private float _LocationPointerX;
		[SerializeField]
		private float _LocationPointerY;
		[SerializeField]
		private int _ReleaseQuestId;
		[SerializeField]
		private int _ClearQuestId;
		[SerializeField]
		private string _TopBannerImage;
		[SerializeField]
		private string _HowToPlayImage;
		[SerializeField]
		private int _HowToPlayCount;
		[SerializeField]
		private int _ShowTriggerEntityId;
		[SerializeField]
		private int _ShowTriggerEntityQuantity;
	
		// Properties
		public int Id { get; }
		public int EventId { get; }
		public int LocationRewardId { get; }
		public string LocationName { get; }
		public float LocationPointerX { get; }
		public float LocationPointerY { get; }
		public int ReleaseQuestId { get; }
		public int ClearQuestId { get; }
		public string TopBannerImage { get; }
		public string HowToPlayImage { get; }
		public int HowToPlayCount { get; }
		public int ShowTriggerEntityId { get; }
		public int ShowTriggerEntityQuantity { get; }
	
		// Constructors
		public CombatEventLocationElement();
	}
}
