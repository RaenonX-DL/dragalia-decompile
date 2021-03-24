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
	public class DragonGiftDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _Descripsion;
		[SerializeField]
		private DragonGiftType _DragonGiftType;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _Reliability;
		[SerializeField]
		private int _FavoriteReliability;
		[SerializeField]
		private DragonFavoriteType _FavoriteType;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string Descripsion { get; }
		public DragonGiftType DragonGiftType { get; }
		public int SortId { get; }
		public int Reliability { get; }
		public int FavoriteReliability { get; }
		public DragonFavoriteType FavoriteType { get; }
	
		// Constructors
		public DragonGiftDataElement();
	}
}
