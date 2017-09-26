using System;
using System.Collections.Generic;
using System.Text;

namespace track_management.ClassicalStyle.Tests.WellKnownTypes
{
    public static class WellKnownTalks
    {

	    public static WellKnownTalk[] ReturnAllWellKnownTalks()
	    {
		    return new WellKnownTalk[] 
						{
							WritingFastTestsAgainstEnterpriseRails(),
							OverdoingItInPython(),
							RubyErrorsFromMismatchedGemVersions(),
							CommonRubyErrors(),
							RailsForPythonDevelopers(),
							CommunicatingOverDistance(),
							AccountingDrivenDevelopment(),
							Woah(),
							SitDownAndWrite(),
							PairProgrammingVsNoise(),
							RubyOnRailsWhyWeShouldMoveOn(),
							ClojureAteScala(),
							ProgrammingInTheBoondocksOfSeattle(),
							RubyVsClojureForBackEndDevelopment(),
							RubyOnRailsLegacyAppMaintenance(),
							AWorldWithoutHackerNews(),
							UserInterfaceCSSInRailsApps()

						};
		}


	    public static WritingFastTestsAgainstEnterpriseRails WritingFastTestsAgainstEnterpriseRails()
	    {
		    return new WritingFastTestsAgainstEnterpriseRails();
	    }

	    public static OverdoingItInPython OverdoingItInPython()
	    {
		    return new OverdoingItInPython();
	    }

	    public static RubyErrorsFromMismatchedGemVersions RubyErrorsFromMismatchedGemVersions()
	    {
		    return new RubyErrorsFromMismatchedGemVersions();
	    }

	    public static CommonRubyErrors CommonRubyErrors()
	    {
		    return new CommonRubyErrors();
	    }

	    public static RailsForPythonDevelopers RailsForPythonDevelopers()
	    {
		    return new RailsForPythonDevelopers();
	    }

		public static CommunicatingOverDistance CommunicatingOverDistance()
		{
			return new CommunicatingOverDistance();
		}

	    public static AccountingDrivenDevelopment AccountingDrivenDevelopment()
	    {
		    return new AccountingDrivenDevelopment();
	    }

	    public static Woah Woah()
	    {
		    return new Woah();
	    }

	    public static SitDownAndWrite SitDownAndWrite()
	    {
		    return new SitDownAndWrite();
	    }

	    public static PairProgrammingVsNoise PairProgrammingVsNoise()
	    {
		    return new PairProgrammingVsNoise();
	    }

	    public static RubyOnRailsWhyWeShouldMoveOn RubyOnRailsWhyWeShouldMoveOn()
	    {
		    return new RubyOnRailsWhyWeShouldMoveOn();
	    }

	    public static ClojureAteScala ClojureAteScala()
	    {
		    return new ClojureAteScala();
	    }

	    public static ProgrammingInTheBoondocksOfSeattle ProgrammingInTheBoondocksOfSeattle()
	    {
		    return new ProgrammingInTheBoondocksOfSeattle();
	    }

	    public static RubyVsClojureForBackEndDevelopment RubyVsClojureForBackEndDevelopment()
	    {
		    return new RubyVsClojureForBackEndDevelopment();
	    }

	    public static RubyOnRailsLegacyAppMaintenance RubyOnRailsLegacyAppMaintenance()
	    {
		    return new RubyOnRailsLegacyAppMaintenance();
	    }

	    public static AWorldWithoutHackerNews AWorldWithoutHackerNews()
	    {
		    return new AWorldWithoutHackerNews();
	    }

	    public static UserInterfaceCSSInRailsApps UserInterfaceCSSInRailsApps()
	    {
		    return new UserInterfaceCSSInRailsApps();
	    }

	}

	public class WritingFastTestsAgainstEnterpriseRails : WellKnownTalk
	{
		public override string Name => "Writing Fast Tests Against Enterprise Rails";

		public override int Duration => 60;
	}

	public class OverdoingItInPython : WellKnownTalk
	{
		public override string Name => "Overdoing it in Python";

		public override int Duration => 45;
	}

	public class RubyErrorsFromMismatchedGemVersions : WellKnownTalk
	{
		public override string Name => "Ruby Errors from Mismatched Gem Versions";

		public override int Duration => 45;
	}

	public class CommonRubyErrors : WellKnownTalk
	{
		public override string Name => "Common Ruby Errors";

		public override int Duration => 45;
	}

	public class RailsForPythonDevelopers : WellKnownTalk
	{
		public override string Name => "Rails for Python Developers";

		public override int Duration => 5;
	}

	public class CommunicatingOverDistance : WellKnownTalk
	{
		public override string Name => "Communicating Over Distance";

		public override int Duration => 60;
	}

	public class AccountingDrivenDevelopment : WellKnownTalk
	{
		public override string Name => "Accounting-Driven Development";

		public override int Duration => 45;
	}

	public class Woah : WellKnownTalk
	{
		public override string Name => "Woah";

		public override int Duration => 30;
	}

	public class SitDownAndWrite : WellKnownTalk
	{
		public override string Name => "Sit Down and Write";

		public override int Duration => 30;
	}

	public class PairProgrammingVsNoise : WellKnownTalk
	{
		public override string Name => "Pair Programming vs Noise";

		public override int Duration => 45;
	}

	public class RailsMagic : WellKnownTalk
	{
		public override string Name => "Rails Magic";

		public override int Duration => 60;
	}

	public class RubyOnRailsWhyWeShouldMoveOn : WellKnownTalk
	{
		public override string Name => "Ruby on Rails: Why We Should Move On";

		public override int Duration => 60;
	}

	public class ClojureAteScala : WellKnownTalk
	{
		public override string Name => "Clojure Ate Scala";

		public override int Duration => 45;
	}

	public class ProgrammingInTheBoondocksOfSeattle : WellKnownTalk
	{
		public override string Name => "Programming in the Boondocks of Seattle";

		public override int Duration => 30;
	}

	public class RubyVsClojureForBackEndDevelopment : WellKnownTalk
	{
		public override string Name => "Ruby vs. Clojure for Back-End Development";

		public override int Duration => 30;
	}

	public class RubyOnRailsLegacyAppMaintenance : WellKnownTalk
	{
		public override string Name => "Ruby on Rails Legacy App Maintenance";

		public override int Duration => 60;
	}

	public class AWorldWithoutHackerNews : WellKnownTalk
	{
		public override string Name => "A World Without HackerNews";

		public override int Duration => 30;
	}

	public class UserInterfaceCSSInRailsApps : WellKnownTalk
	{
		public override string Name => "User Interface CSS in Rails Apps";

		public override int Duration => 30;
	}

}
