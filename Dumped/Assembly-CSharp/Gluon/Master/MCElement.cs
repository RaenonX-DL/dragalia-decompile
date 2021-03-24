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
	public class MCElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Hierarchy;
		[SerializeField]
		private int _No;
		[SerializeField]
		private ManaPieceType _ManaPieceType;
		[SerializeField]
		private int _IsReleaseStory;
		[SerializeField]
		private int _NecessaryManaPoint;
		[SerializeField]
		private int _UniqueGrowMaterialCount1;
		[SerializeField]
		private int _UniqueGrowMaterialCount2;
		[SerializeField]
		private int _GrowMaterialCount;
	
		// Properties
		public int Id { get; }
		public int Hierarchy { get; }
		public int No { get; }
		public ManaPieceType ManaPieceType { get; }
		public int IsReleaseStory { get; }
		public int NecessaryManaPoint { get; }
		public int UniqueGrowMaterialCount1 { get; }
		public int UniqueGrowMaterialCount2 { get; }
		public int GrowMaterialCount { get; }
	
		// Constructors
		public MCElement();
	}
}
