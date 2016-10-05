﻿using System;

namespace Nexus.Client
{
	/// <summary>
	/// Tracks the application's metadata.
	/// </summary>
	public static class ProgrammeMetadata
	{
		/// <summary>
		/// The string representation of the version of the application.
		/// </summary>
		/// <remarks>
		/// The version is in the form: a.b.c
		/// 
		/// (a) should change when there is a major alteration to the programme.
		/// Something akin to a UI overhaul, or a major new feature that alters
		/// how users will interact with the application.
		/// 
		/// (b) should change when there is a normal alteration to the programme.
		/// Something akin to regular maintenance, a major bug fix, or a simple
		/// new feature addition.
		/// 
		/// (c) should change when there is a minor alteration to the programme.
		/// Something akin to a minor bug fix, or a typo correction.
		/// </remarks>
<<<<<<< HEAD
		public const string VersionString = "0.62.1";
=======
		public const string VersionString = "0.62.2";
>>>>>>> 9b5fd082048aaaa2a613675e8ec9a4933eb59567

		/// <summary>
		/// Gets the full name of the mod manager.
		/// </summary>
		public const string ModManagerName = "Nexus Mod Manager";
	}
}
