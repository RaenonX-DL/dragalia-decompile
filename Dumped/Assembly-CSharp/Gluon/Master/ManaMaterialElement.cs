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
	public class ManaMaterialElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _FireMaterialId;
		[SerializeField]
		private int _WaterMaterialId;
		[SerializeField]
		private int _WindMaterialId;
		[SerializeField]
		private int _LightMaterialId;
		[SerializeField]
		private int _DarkMaterialId;
	
		// Properties
		public int Id { get; }
		public int FireMaterialId { get; }
		public int WaterMaterialId { get; }
		public int WindMaterialId { get; }
		public int LightMaterialId { get; }
		public int DarkMaterialId { get; }
	
		// Constructors
		public ManaMaterialElement();
	}
}
