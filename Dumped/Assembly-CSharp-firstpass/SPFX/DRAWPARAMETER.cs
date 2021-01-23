/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public struct DRAWPARAMETER
	{
		// Fields
		public long RenderTexturePtr;
		public long DepthTexturePtr;
		public long ColorBufferNativePtr;
		public long DepthBufferNativePtr;
		public MATRIX4x4 ViewMatrix;
		public MATRIX4x4 ProjectionMatrix;
		public PLANE FrustumL;
		public PLANE FrustumR;
		public PLANE FrustumT;
		public PLANE FrustumB;
		public PLANE FrustumN;
		public PLANE FrustumF;
		public VECTOR3 LightDirection;
		public VECTOR3 LightColor;
		public VECTOR3 AmbientColor;
		public int CullingMask;
		public int DrawLayerFlags;
		public int DebugInfoType;
		public int PixelWidth;
		public int PixelHeight;
		public int Flags;
	}
}
