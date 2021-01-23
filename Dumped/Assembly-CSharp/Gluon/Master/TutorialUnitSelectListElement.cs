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
	public class TutorialUnitSelectListElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _UnitSelelctGroupId;
		[SerializeField]
		private GiftType _SelectEntityType;
		[SerializeField]
		private int _SelectEntityId;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _IsPickup;
		[SerializeField]
		private string _IntroductionText;
	
		// Properties
		public int Id { get; }
		public int UnitSelelctGroupId { get; }
		public GiftType SelectEntityType { get; }
		public int SelectEntityId { get; }
		public int SortId { get; }
		public int IsPickup { get; }
		public string IntroductionText { get; }
	
		// Constructors
		public TutorialUnitSelectListElement();
	}
}
