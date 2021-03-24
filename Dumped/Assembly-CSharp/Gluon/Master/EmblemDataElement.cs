/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EmblemDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private string _Ruby;
		[SerializeField]
		private int _Rarity;
		[SerializeField]
		private int _EmblemType;
		[SerializeField]
		private int _Sortid;
		[SerializeField]
		private string _Gettext;
		[SerializeField]
		private GiftType _DuplicateEntityType;
		[SerializeField]
		private int _DuplicateEntityId;
		[SerializeField]
		private int _DuplicateEntityQuantity;
	
		// Properties
		public int Id { get; }
		public string Title { get; }
		public string Ruby { get; }
		public int Rarity { get; }
		public int EmblemType { get; }
		public int Sortid { get; }
		public string Gettext { get; }
		public GiftType DuplicateEntityType { get; }
		public int DuplicateEntityId { get; }
		public int DuplicateEntityQuantity { get; }
	
		// Constructors
		public EmblemDataElement();
	}
}
