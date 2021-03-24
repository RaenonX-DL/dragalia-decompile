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
	public class ActionTargetElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Label;
		[SerializeField]
		private ActionTargetGroup _Group;
	
		// Properties
		public int Id { get; }
		public string Label { get; }
		public ActionTargetGroup Group { get; }
	
		// Constructors
		public ActionTargetElement();
	}
}
