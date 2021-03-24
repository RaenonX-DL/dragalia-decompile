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
	public class Keyframe
	{
		// Fields
		[CompilerGenerated]
		private Color _color_k__BackingField;
		[CompilerGenerated]
		private List<CustomEase> _customEase_k__BackingField;
		[CompilerGenerated]
		private float _index_k__BackingField;
		[CompilerGenerated]
		private float _x_k__BackingField;
		[CompilerGenerated]
		private float _y_k__BackingField;
		[CompilerGenerated]
		private float _scaleX_k__BackingField;
		[CompilerGenerated]
		private float _scaleY_k__BackingField;
		[CompilerGenerated]
		private float _rotation_k__BackingField;
	
		// Properties
		[XmlElement]
		public Color color { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlElement]
		public List<CustomEase> customEase { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float index { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float x { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float y { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float scaleX { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float scaleY { [CompilerGenerated] get; [CompilerGenerated] set; }
		[XmlAttribute]
		public float rotation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public Keyframe();
	}
}
