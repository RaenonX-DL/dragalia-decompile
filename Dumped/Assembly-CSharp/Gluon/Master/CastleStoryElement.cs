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
	public class CastleStoryElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private int _SortKey;
		[SerializeField]
		private string _ThumbnailImage;
		[SerializeField]
		private GiftType _ReleaseEntityType;
		[SerializeField]
		private int _ReleaseEntityId;
		[SerializeField]
		private int _ReleaseEntityQuantity;
		[SerializeField]
		private string _ReleaseDate;
	
		// Properties
		public int Id { get; }
		public string Title { get; }
		public int SortKey { get; }
		public string ThumbnailImage { get; }
		public GiftType ReleaseEntityType { get; }
		public int ReleaseEntityId { get; }
		public int ReleaseEntityQuantity { get; }
		public string ReleaseDate { get; }
	
		// Constructors
		public CastleStoryElement();
	}
}
