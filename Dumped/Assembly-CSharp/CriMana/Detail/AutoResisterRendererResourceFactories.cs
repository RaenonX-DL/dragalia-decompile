/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana.Detail
{
	public static class AutoResisterRendererResourceFactories
	{
		// Nested types
		[RendererResourceFactoryPriority]
		public class RendererResourceFactoryAndroidH264Rgb : RendererResourceFactory
		{
			// Constructors
			public RendererResourceFactoryAndroidH264Rgb();
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
			protected override void OnDisposeManaged();
			protected override void OnDisposeUnmanaged();
		}
	
		[RendererResourceFactoryPriority]
		public class RendererResourceFactoryAndroidSofdecPrimeYuv : RendererResourceFactory
		{
			// Constructors
			public RendererResourceFactoryAndroidSofdecPrimeYuv();
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
			protected override void OnDisposeManaged();
			protected override void OnDisposeUnmanaged();
		}
	
		[RendererResourceFactoryPriority]
		public class RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2 : RendererResourceFactory
		{
			// Constructors
			public RendererResourceFactoryAndroidSofdecPrimeYuvLegacyGles2();
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
			protected override void OnDisposeManaged();
			protected override void OnDisposeUnmanaged();
		}
	
		[RendererResourceFactoryPriority]
		public class RendererResourceFactoryySofdecVp9Yuv : RendererResourceFactory
		{
			// Constructors
			public RendererResourceFactoryySofdecVp9Yuv();
	
			// Methods
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
			protected override void OnDisposeManaged();
			protected override void OnDisposeUnmanaged();
		}
	
		// Methods
		public static void InvokeAutoRegister();
	}
}
