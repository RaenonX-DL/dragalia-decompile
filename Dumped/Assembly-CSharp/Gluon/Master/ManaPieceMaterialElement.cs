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
	public class ManaPieceMaterialElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ElementId;
		[SerializeField]
		private ManaPieceType _ManaPieceType;
		[SerializeField]
		private int _Step;
		[SerializeField]
		private int _MaterialId1;
		[SerializeField]
		private int _MaterialQuantity1;
		[SerializeField]
		private int _MaterialId2;
		[SerializeField]
		private int _MaterialQuantity2;
		[SerializeField]
		private int _MaterialId3;
		[SerializeField]
		private int _MaterialQuantity3;
		[SerializeField]
		private int _DewPoint;
	
		// Properties
		public int Id { get; }
		public int ElementId { get; }
		public ManaPieceType ManaPieceType { get; }
		public int Step { get; }
		public int MaterialId1 { get; }
		public int MaterialQuantity1 { get; }
		public int MaterialId2 { get; }
		public int MaterialQuantity2 { get; }
		public int MaterialId3 { get; }
		public int MaterialQuantity3 { get; }
		public int DewPoint { get; }
	
		// Constructors
		public ManaPieceMaterialElement();
	}
}
