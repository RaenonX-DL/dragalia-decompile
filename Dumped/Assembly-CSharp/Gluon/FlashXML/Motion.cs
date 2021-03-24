/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.FlashXML
{
	[XmlRoot]
	public class Motion
	{
		// Fields
		[CompilerGenerated]
		private Source _source_k__BackingField;
		[CompilerGenerated]
		private List<Keyframe> _keyframeList_k__BackingField;
		[CompilerGenerated]
		private float _duration_k__BackingField;
	
		// Properties
		[XmlElement]
		public Source source { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlElement]
		public List<Keyframe> keyframeList { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public Motion();
	}
}
