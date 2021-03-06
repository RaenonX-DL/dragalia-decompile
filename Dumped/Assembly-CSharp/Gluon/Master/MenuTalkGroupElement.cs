﻿/*
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
	public class MenuTalkGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _CharaId;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private int _Category0;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
	
		// Properties
		public int CharaId { get; }
		public int GroupId { get; }
		public int Category0 { get; }
		public int Priority { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
	
		// Constructors
		public MenuTalkGroupElement();
	}
}
