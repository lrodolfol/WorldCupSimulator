using WorldCupSimulator;

Console.WriteLine("==============================================");
Console.WriteLine("=====Welcome to World Cup Simulator 2022!=====");
Console.WriteLine("=========Press any key to continue...=========");
Console.WriteLine("==============================================");
clear();

string op = "N";
var pathFileTeams = "Files\\teams.csv";
List<Team> teamsList = new List<Team>();

teamsList = new List<Team>();

do
{
    teamsList = new List<Team>();

    try
    {
        using (var file = File.OpenText(pathFileTeams))
        {

            while (!file.EndOfStream)
            {

                var lineTeams = file.ReadLine();
                string[]? fields = lineTeams.Split(";");

                if (fields[0] == "0")
                {
                    continue;
                }

                string teamName = fields[1];
                int teamForce = int.Parse(fields[2]);
                string teamGroup = fields[3];

                teamsList.Add(new Team(teamName, teamGroup, teamForce));
            }
        }
    }
    catch(IndexOutOfRangeException ex)
    {
        Console.WriteLine("Oops We found a error: {0}.", ex.Message);
        Console.WriteLine("Please Check the file. All line have a team, force and a group?");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Oops We found a error: {0}. Please Check the file", ex.Message);  
    }
    
    if(teamsList.Count > 0)
    {
        try
        {
            Main main = new Main();
            main.Start(teamsList);
        
            /*GROUPS PHASE*/
            main.FillGroups();
            space();

            /*GROUPS ROUND SEXTEEN*/
            main.FillRoundSexteen();
            space();

            /*GROUPS ROUND EIGHT*/
            main.FillRoundEight();
            space();

            /*GROUPS ROUND SEMI FINAL*/
            main.FillSemiFinal();
            space();

            /*GROUPS ROUND FINAL*/
            main.FillFinal();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops, there are a error: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("there are no teams, please check the file");
    }

    Console.Write("Try Again?  S or N: ");
    op = Console.ReadLine();
    clear();

} while (op == "S");

void clear()
{
    Console.ReadKey();
    Console.Clear();
}

void space()
{
    Console.ReadKey();
    Console.WriteLine(" ");
}