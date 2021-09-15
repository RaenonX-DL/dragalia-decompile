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
	public class BuffIconDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _IconName;
		[SerializeField]
		private int _ValueDisplayType;
		[SerializeField]
		private int _GaugeDisplayType;
	
		// Properties
		public int Id { get; }
		public string IconName { get; }
		public int ValueDisplayType { get; }
		public int GaugeDisplayType { get; }
	
		// Constructors
		public BuffIconDataElement();
	}
}
