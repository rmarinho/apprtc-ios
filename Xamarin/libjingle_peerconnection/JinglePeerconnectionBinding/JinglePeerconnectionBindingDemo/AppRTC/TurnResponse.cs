using System;
using System.Collections.Generic;

namespace JinglePeerconnectionBindingDemo
{
	public class TurnResponse
	{
		public string username { get; set; }
		public string password { get; set; }
		public IList<string> uris { get; set; }
	}
}
