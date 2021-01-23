/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public abstract class CuttTimelineKey
	{
		// Fields
		public int frame;
		public CuttTimelineKeyAttribute attribute;
	
		// Properties
		public abstract CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		protected CuttTimelineKey();
	
		// Methods
		public virtual bool IsInterpolateKey();
		public virtual void OnLoad(CuttTimelineControl timelineControl);
	}
}
