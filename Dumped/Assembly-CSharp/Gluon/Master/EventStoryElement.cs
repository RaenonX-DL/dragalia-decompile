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
	public class EventStoryElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private string _HiraganaPrinted;
		[SerializeField]
		private int _VariationId;
		[SerializeField]
		private string _BannerImage;
		[SerializeField]
		private int _UnlockEventStoryId;
		[SerializeField]
		private int _UnlockQuestStoryId;
		[SerializeField]
		private GiftType _PayEntityType;
		[SerializeField]
		private int _PayEntityId;
		[SerializeField]
		private int _PayEntityQuantity;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
	
		// Properties
		public int Id { get; }
		public string Title { get; }
		public int EventId { get; }
		public int BaseId { get; }
		public string HiraganaPrinted { get; }
		public int VariationId { get; }
		public string BannerImage { get; }
		public int UnlockEventStoryId { get; }
		public int UnlockQuestStoryId { get; }
		public GiftType PayEntityType { get; }
		public int PayEntityId { get; }
		public int PayEntityQuantity { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
	
		// Constructors
		public EventStoryElement();
	}
}
