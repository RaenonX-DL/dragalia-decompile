/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class NetworkSimulationSet
	{
		// Fields
		private bool isSimulationEnabled;
		private int outgoingLag;
		private int outgoingJitter;
		private int outgoingLossPercentage;
		private int incomingLag;
		private int incomingJitter;
		private int incomingLossPercentage;
		internal PeerBase peerBase;
		private Thread netSimThread;
		public readonly ManualResetEvent NetSimManualResetEvent;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private int _LostPackagesOut_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private int _LostPackagesIn_k__BackingField;
	
		// Properties
		protected internal bool IsSimulationEnabled { get; set; }
		public int OutgoingLag { get; }
		public int OutgoingJitter { get; }
		public int OutgoingLossPercentage { get; }
		public int IncomingLag { get; }
		public int IncomingJitter { get; }
		public int IncomingLossPercentage { get; }
		public int LostPackagesOut { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public int LostPackagesIn { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Constructors
		public NetworkSimulationSet();
	
		// Methods
		public override string ToString();
	}
}
