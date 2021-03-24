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
	public class FortAreaElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _FortPrefabName;
		[SerializeField]
		private int _FieldId;
		[SerializeField]
		private int _Unlock;
		[SerializeField]
		private string _Objs1;
		[SerializeField]
		private string _Objs2;
		[SerializeField]
		private string _Objs3;
	
		// Properties
		public int Id { get; }
		public string FortPrefabName { get; }
		public int FieldId { get; }
		public int Unlock { get; }
		public string Objs1 { get; }
		public string Objs2 { get; }
		public string Objs3 { get; }
	
		// Constructors
		public FortAreaElement();
	}
}
