/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class WeaponBodyGroupSeriesElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _GroupSeriesName;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _SeriesLockType;
		[SerializeField]
		private string _SeriesLockText;
	
		// Properties
		public int Id { get; }
		public string GroupSeriesName { get; }
		public int SortId { get; }
		public int SeriesLockType { get; }
		public string SeriesLockText { get; }
	
		// Constructors
		public WeaponBodyGroupSeriesElement();
	}
}
