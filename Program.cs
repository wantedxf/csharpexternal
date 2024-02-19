using System;
using System.Diagnostics;
using System.Threading;

	string text = DateTime.Now.ToString("HH:mm:ss");
	Console.ForegroundColor = ConsoleColor.DarkRed;
	Console.WriteLine(@"                                        .^               .:^.     ..
                                :P?     ~#.    J:.:^~!!7??7!:   ^JJ^       .!!7777?J7777777!!^
                                ^##:    ~@7   :B:77!!^77       75^         .^^::..7P .....:^^J5
      :                  ^J     :GYY    ^&G   ~G      ?Y      ?5                  75        :57
      P!         .~     ^G~     ~P.B.   ^GG!  !P      7P     ~G                   75      :JY^
      ~G         P&.   .B^      YJ Y?   ^G7P  ?Y      ~G     G~                   75    .?Y~
       P7       7P57   JY      .B: ^G   ^G:B. P7      ^G    ?5                    75  :?Y~
       ^G       57!P   P!      J5   G^  ^G P~ G^      :B.   G~   .:~7:            ~P.?Y~
        G~      P!.B.  P!     ^G.   JJ  ^G Y?.B.      .B.  ^#?7???7!^.            ^#Y~
        !P      G~ P!  P~     P5!!775B  ~G ?Y.B.      .B.  7#^:.                ^JJ^
         G~     B^ JJ  G^    7P^^::::B: ?5 75.B.      .B.  .B.                ^JY^
         !G    ^G  !P ^B.   ^B:      YJ YJ ~P.B.      .B.   YJ    .~J.     .7Y?:
          5?   P!  ^G 5J   :G~       ^5 P~ ~G:B.      .B.    JJ77?J7:     .J!.
          .B^ 5J   .B?G.  .5~           .  :G!G       .5.     ....
           ~G5Y     ~Y:                     PBJ
            ??                              !B^");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
	Console.WriteLine("------------------------------------------------------------------------------------------------");
	Console.ForegroundColor = ConsoleColor.Red;
	Thread.Sleep(3000);
	string processName = "RobloxPlayerBeta";
	Process[] processesByName = Process.GetProcessesByName(processName);
	if (processesByName.Length > 0)
	{
		Console.WriteLine("[" + text + "] Searching for roblox...");
		Thread.Sleep(1500);
		Console.WriteLine("[" + text + "] ...");
		Thread.Sleep(1500);
		Console.WriteLine("[" + text + "] Injecting... Please wait");
		Thread.Sleep(1500);
		Console.WriteLine("[" + text + "] ...");
		Thread.Sleep(3000);
		Process process = processesByName[0];
		process.Kill();
		Thread.Sleep(1500);
		Console.WriteLine("[" + text + "] Byfron Bypassed. Reopen roblox, keep this console open, and enjoy scripting.");
		Thread.Sleep(-1);
	}
	else
	{
		Console.WriteLine("[" + text + "] Searching for roblox...");
		Thread.Sleep(1500);
		Console.WriteLine("[" + text + "] ...");
		Thread.Sleep(750);
		Console.WriteLine("[" + text + "] Roblox is not open, restart application **after** running roblox.");
		Thread.Sleep(3000);
		Console.WriteLine("[" + text + "] You can close this window now.");
		Thread.Sleep(-1);
	}
	Console.ReadLine();
	Thread.Sleep(-1);
