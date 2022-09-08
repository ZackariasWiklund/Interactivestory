
string val = "";


Console.WriteLine("Du råkar gå in i en person, han blir extremt arg och vill slåss, vad gör du? Försöker du prata med honom eller börjar du slåss?");
Console.WriteLine();
Console.WriteLine("   Alternativ:   [Slåss]   [Prata med honom]");
val = Console.ReadLine();

if (val == "slåss")
{
Console.Clear();
Console.WriteLine("Du slår honom i ansiktet men han slår dig också, sista chansen att försöka prata dig ur detta, vad gör du? fortsätter du slåss eller försöker du prata dig ur situationen?");
Console.WriteLine();
Console.WriteLine("   Alternativ:   [Slåss]   [Försöker prata mig ur situationen]");
val = Console.ReadLine();
val = val.ToLower();

}

if (val.ToLower() == "slåss")
{
    Console.Clear();
    Console.WriteLine("Du fortsätter att slåss mot honom, men du är extremt svag och han knockar dig på mindre än en sekund.");

    badending();

    Console.ReadLine();
}

else if (val.ToLower() == "försöker prata mig ur situationen")
{   
    Console.Clear();
    Console.WriteLine("Efter att du slagit honom i ansiktet så försöker du prata med honom? Han går inte med på det och slår dig rakt i kinden, du blir knockad.");
    badending ();
    Console.ReadLine();
    
    
}

//--------------------------------------------------------------------------------------

else if (val.ToLower() == "prata med honom")
{   
    Console.Clear();
    Console.WriteLine("Han börjar lugna ner sig lite grann, detta är bästa chansen att göra en sneak attack, vad gör du? fortsätter du att försöka lugna ner honom eller gör du en sneak attack?");
    Console.WriteLine();
    Console.WriteLine("   Alternativ:   [Lugna ner honom]   [Sneak attack]");
    val = Console.ReadLine();
}

if (val.ToLower() == "lugna ner honom")
{   
    Console.Clear();
    Console.WriteLine("Personen lugnar ner sig och du kan nu berätta att det inte var meningen. Du lyckas förklara för honom och allting är nu lugnt.");
    goodending();
    Console.ReadLine();
}

else if (val.ToLower() == "sneak attack")
{   
    Console.Clear();
    Console.WriteLine("Han var faktiskt inte beredd på att du skulle vara så feg och göra en sneak attack, så du lyckas slå honom rakt i kinden. Men du var så himla svag att han inte ens kände slaget, nu är han vansinnig, vad gör du? Gör du ett sista försök att prata dig ur det eller springer du där ifrån?");
    Console.WriteLine();
    Console.WriteLine("   Alternativ:   [Sista försök att prata]   [Springer därifrån]");
    val = Console.ReadLine();
}

if (val.ToLower() == "sista försök att prata")
{
    Console.Clear();
    Console.WriteLine("Du är galen, han är just nu vansinnig och du ställer dig där och försöker prata med honom? Nah han one shot KO'ar dig.");
    badending();
    Console.ReadLine();
}

else if (val.ToLower() == "springer därifrån")
{   
    Console.Clear();
    Console.WriteLine("Som tur var så var du inte lika långsam som du är svag, du lyckas springa ifrån honom men du har nu en fiende för livet.");
    neutralending();
    Console.ReadLine();
}


else {

    Console.WriteLine("Inte ett av alternativen, spelet stängs nu ner");
    Console.ReadLine();
}

void badending (){
    
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"
    
    
██████╗░░█████╗░██████╗░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
██╔══██╗██╔══██╗██╔══██╗  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██████╦╝███████║██║░░██║  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██╔══██╗██╔══██║██║░░██║  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
██████╦╝██║░░██║██████╔╝  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝
    
    ");
    Console.ForegroundColor = ConsoleColor.White;

}

void goodending (){
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
    
    
░██████╗░░█████╗░░█████╗░██████╗░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
██╔════╝░██╔══██╗██╔══██╗██╔══██╗  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██║░░██╗░██║░░██║██║░░██║██║░░██║  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██║░░╚██╗██║░░██║██║░░██║██║░░██║  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
╚██████╔╝╚█████╔╝╚█████╔╝██████╔╝  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
░╚═════╝░░╚════╝░░╚════╝░╚═════╝░  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝
    
    ");
    Console.ForegroundColor = ConsoleColor.White;



}


void neutralending (){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(@"
    

███╗░░██╗███████╗██╗░░░██╗████████╗██████╗░░█████╗░██╗░░░░░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
████╗░██║██╔════╝██║░░░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██╔██╗██║█████╗░░██║░░░██║░░░██║░░░██████╔╝███████║██║░░░░░  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██║╚████║██╔══╝░░██║░░░██║░░░██║░░░██╔══██╗██╔══██║██║░░░░░  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
██║░╚███║███████╗╚██████╔╝░░░██║░░░██║░░██║██║░░██║███████╗  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
╚═╝░░╚══╝╚══════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝
    
    ");
    Console.ForegroundColor = ConsoleColor.White;
    
}

