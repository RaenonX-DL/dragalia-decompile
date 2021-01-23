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
	public class LoginBonusDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _LoginBonusName;
		[SerializeField]
		private int _IsLoop;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _StartTime;
		[SerializeField]
		private string _EndTime;
		[SerializeField]
		private GiftType _EachDayEntityType;
		[SerializeField]
		private int _EachDayEntityId;
		[SerializeField]
		private int _EachDayEntityQuantity;
	
		// Properties
		public int Id { get; }
		public string LoginBonusName { get; }
		public int IsLoop { get; }
		public int SortId { get; }
		public string StartTime { get; }
		public string EndTime { get; }
		public GiftType EachDayEntityType { get; }
		public int EachDayEntityId { get; }
		public int EachDayEntityQuantity { get; }
	
		// Constructors
		public LoginBonusDataElement();
	}
}
