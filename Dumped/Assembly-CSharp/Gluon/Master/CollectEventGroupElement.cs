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
	public class CollectEventGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _StoryGroupType;
		[SerializeField]
		private string _StoryGroupName;
		[SerializeField]
		private string _StoryBannerImage;
	
		// Properties
		public int Id { get; }
		public int StoryGroupType { get; }
		public string StoryGroupName { get; }
		public string StoryBannerImage { get; }
	
		// Constructors
		public CollectEventGroupElement();
	}
}
