/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class MissionDrillDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _TextTitle;
		[SerializeField]
		private string _TextDetail;
		[SerializeField]
		private string _IconImage;
		[SerializeField]
		private int _MissionDrillGroupId;
		[SerializeField]
		private int _Step;
		[SerializeField]
		private int _IsPickUp;
		[SerializeField]
		private int _CompleteValue;
		[SerializeField]
		private int _ProgressFlag;
		[SerializeField]
		private MissionTransportType _MissionTransportType;
		[SerializeField]
		private int _TransportValue;
		[SerializeField]
		private GiftType _EntityType;
		[SerializeField]
		private int _EntityId;
		[SerializeField]
		private int _EntityQuantity;
		[SerializeField]
		private int _NeedCompleteMissionId;
	
		// Properties
		public int Id { get; }
		public string TextTitle { get; }
		public string TextDetail { get; }
		public string IconImage { get; }
		public int MissionDrillGroupId { get; }
		public int Step { get; }
		public int IsPickUp { get; }
		public int CompleteValue { get; }
		public int ProgressFlag { get; }
		public MissionTransportType MissionTransportType { get; }
		public int TransportValue { get; }
		public GiftType EntityType { get; }
		public int EntityId { get; }
		public int EntityQuantity { get; }
		public int NeedCompleteMissionId { get; }
	
		// Constructors
		public MissionDrillDataElement();
	}
}
