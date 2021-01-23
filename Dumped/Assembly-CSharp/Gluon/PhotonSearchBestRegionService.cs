/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonSearchBestRegionService
	{
		// Fields
		private RequestType _request;
		private ResultType _result;
		private List<PingTask> _taskList;
		private List<RttResultType> _rttResultList;
		private State _state;
		private bool _isAnyTaskCompleted;
	
		// Nested types
		public struct RequestType
		{
			// Fields
			public PhotonClusterSet clusterSet;
			public PhotonClusterRttResult rttCache;
		}
	
		public struct ResultType
		{
			// Fields
			public PhotonCluster bestRegionCluster;
		}
	
		private enum State
		{
			None = 0,
			Running = 1,
			Completed = 2
		}
	
		private class RttResultType
		{
			// Fields
			public PhotonCluster cluster;
			public float rtt;
	
			// Constructors
			public RttResultType();
		}
	
		private class GluonPing : PhotonPing
		{
			// Fields
			private Socket sock;
	
			// Constructors
			public GluonPing();
	
			// Methods
			public override bool StartPing(string ip);
			public override bool Done();
			public override void Dispose();
		}
	
		private class PingTask
		{
			// Fields
			public static readonly int Attempts;
			public static readonly int MaxMilliseconsPerPing;
			private State _state;
			private int _sendCount;
			private GluonPing _ping;
			private RttResultType _result;
			private Stopwatch sw;
	
			// Properties
			public PhotonCluster Cluster { get; }
			public bool IsCompleted { get; }
			public bool HasResult { get; }
			public RttResultType Result { get; }
	
			// Nested types
			private enum State
			{
				None = 0,
				Pinging = 1,
				Completed = 2
			}
	
			// Constructors
			public PingTask(PhotonCluster cluster);
			static PingTask();
	
			// Methods
			public void Destroy();
			private void StartPing(string hostname);
			public void Update();
			public static string ResolveHost(string hostName);
		}
	
		// Constructors
		public PhotonSearchBestRegionService();
	
		// Methods
		public void Clear();
		public void Start(RequestType req);
		public void Update();
		public bool IsCompleted();
		public ResultType GetResult();
		public void _StartTask(List<PhotonCluster> clusters);
		private void UpdateTask();
	}
}
