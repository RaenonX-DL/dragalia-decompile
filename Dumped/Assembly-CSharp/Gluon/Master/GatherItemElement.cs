/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class GatherItemElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _Detail;
		[SerializeField]
		private int _QuestWeeklyTakeLimit;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string Detail { get; }
		public int QuestWeeklyTakeLimit { get; }
	
		// Constructors
		public GatherItemElement();
	}
}
