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
	public class TutorialUnitSelectElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _UnitSelelctGroupId;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
	
		// Properties
		public int Id { get; }
		public int UnitSelelctGroupId { get; }
		public string StartDate { get; }
		public string EndDate { get; }
	
		// Constructors
		public TutorialUnitSelectElement();
	}
}
