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
	public class SummonPointDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _SummonId;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
	
		// Properties
		public int Id { get; }
		public int SummonId { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
	
		// Constructors
		public SummonPointDataElement();
	}
}
