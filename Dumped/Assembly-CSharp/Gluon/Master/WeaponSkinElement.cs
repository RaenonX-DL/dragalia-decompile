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
	public class WeaponSkinElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private WeaponType _WeaponType;
		[SerializeField]
		private int _Rarity;
		[SerializeField]
		private ElementalType _ElementalType;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private int _VariationId;
		[SerializeField]
		private int _FormId;
		[SerializeField]
		private int _DecBaseId;
		[SerializeField]
		private int _DecVariationId;
		[SerializeField]
		private int _BulletBaseId;
		[SerializeField]
		private int _BulletVariationId;
		[SerializeField]
		private int _IsPlayable;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private GiftType _DuplicateEntityType;
		[SerializeField]
		private int _DuplicateEntityId;
		[SerializeField]
		private int _DuplicateEntityQuantity;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public WeaponType WeaponType { get; }
		public int Rarity { get; }
		public ElementalType ElementalType { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int FormId { get; }
		public int DecBaseId { get; }
		public int DecVariationId { get; }
		public int BulletBaseId { get; }
		public int BulletVariationId { get; }
		public int IsPlayable { get; }
		public string Text { get; }
		public GiftType DuplicateEntityType { get; }
		public int DuplicateEntityId { get; }
		public int DuplicateEntityQuantity { get; }
	
		// Constructors
		public WeaponSkinElement();
	}
}
