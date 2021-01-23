/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana.Detail
{
	public abstract class RendererResourceFactory : IDisposable
	{
		// Fields
		private static SortedList<int, RendererResourceFactory> factoryList;
		private bool disposed;
	
		// Constructors
		protected RendererResourceFactory();
		static RendererResourceFactory();
	
		// Methods
		public static void RegisterFactory(RendererResourceFactory factory, int priority);
		public static void DisposeAllFactories();
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		~RendererResourceFactory();
		public void Dispose();
		private void Dispose(bool disposing);
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	}
}
