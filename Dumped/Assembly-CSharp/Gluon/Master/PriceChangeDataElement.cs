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
	public class PriceChangeDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _PriceChangeType;
		[SerializeField]
		private int _Step;
		[SerializeField]
		private int _PaymentType;
		[SerializeField]
		private int _NeedCost;
	
		// Properties
		public int Id { get; }
		public int PriceChangeType { get; }
		public int Step { get; }
		public int PaymentType { get; }
		public int NeedCost { get; }
	
		// Constructors
		public PriceChangeDataElement();
	}
}
