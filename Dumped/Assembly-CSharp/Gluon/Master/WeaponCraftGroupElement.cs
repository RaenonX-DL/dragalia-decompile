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
	public class WeaponCraftGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private WeaponType _CraftWeaponType;
		[SerializeField]
		private string _CraftGroupName;
		[SerializeField]
		private int _CraftSeriesId;
		[SerializeField]
		private string _CraftSeriesImage;
		[SerializeField]
		private string _CraftHeaderImage;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _PickupEventId;
		[SerializeField]
		private string _PickupStartDate;
		[SerializeField]
		private string _PickupEndDate;
	
		// Properties
		public int Id { get; }
		public WeaponType CraftWeaponType { get; }
		public string CraftGroupName { get; }
		public int CraftSeriesId { get; }
		public string CraftSeriesImage { get; }
		public string CraftHeaderImage { get; }
		public int SortId { get; }
		public int PickupEventId { get; }
		public string PickupStartDate { get; }
		public string PickupEndDate { get; }
	
		// Constructors
		public WeaponCraftGroupElement();
	}
}
