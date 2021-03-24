/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartsTextureScroll : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private PartsTextureScrollData[] _partsTextureScrollData;
		[SerializeField]
		[Tooltip]
		private bool enableStopProduction;
		private RenderPartsData _renderPartsData;
		private float _startTime;
	
		// Constructors
		public PartsTextureScroll();
	
		// Methods
		private void Awake();
		private void Start();
		protected void Reset();
		public override void FastUpdate();
	}
}
