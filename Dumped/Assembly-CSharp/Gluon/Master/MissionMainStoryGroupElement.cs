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
	public class MissionMainStoryGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private string _LockText;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _AnimationInfo;
	
		// Properties
		public int Id { get; }
		public string Text { get; }
		public string LockText { get; }
		public int SortId { get; }
		public string AnimationInfo { get; }
	
		// Constructors
		public MissionMainStoryGroupElement();
	}
}
