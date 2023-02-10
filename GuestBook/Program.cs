using GuestBook;

Console.WriteLine("Welcome to the Guest Book App!\n" +
    "**************************************************\n");

var party = ConsoleMessages.LoopAndAddToList();

ConsoleMessages.PrintInfo(party.partyNames, party.partyGuestAmount);

