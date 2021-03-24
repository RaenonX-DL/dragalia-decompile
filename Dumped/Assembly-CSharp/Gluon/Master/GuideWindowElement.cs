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
	public class GuideWindowElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _GuideGroupId;
		[SerializeField]
		private int _GuideType;
		[SerializeField]
		private int _PageNum;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private string _ImageName;
		[SerializeField]
		private string _Text;
	
		// Properties
		public int Id { get; }
		public int GuideGroupId { get; }
		public int GuideType { get; }
		public int PageNum { get; }
		public string Title { get; }
		public string ImageName { get; }
		public string Text { get; }
	
		// Constructors
		public GuideWindowElement();
	}
}
