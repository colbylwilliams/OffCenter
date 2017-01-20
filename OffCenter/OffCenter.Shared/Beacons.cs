using System;
using System.Linq;
using System.Collections.Generic;

namespace OffCenter.Shared
{
	public enum Beacons
	{
		Build,
		Test,
		Distribute,
		Tables,
		Identity,
		Crashes,
		Analytics
	}


	public class Beacon
	{
		static Dictionary<Beacons, Beacon> _all;

		public static Dictionary<Beacons, Beacon> All =>
			_all ?? (_all = Enum.GetValues (typeof (Beacons))
								 .Cast<Beacons> ()
								 .Select (b => new KeyValuePair<Beacons, Beacon> (b, new Beacon (b)))
								 .ToDictionary (kv => kv.Key, kv => kv.Value));


		public Beacon (Beacons beacon)
		{
			Title = beacon.ToString ();
			Icon = $"i_beacon_{Title.ToLowerInvariant ()}";
		}


		public string Title { get; set; }

		public string Icon { get; set; }
	}
}
