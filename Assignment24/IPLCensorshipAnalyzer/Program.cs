using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string jsonInputPath = "ipl_matches.json";
        string csvInputPath = "ipl_matches.csv";
        string jsonOutputPath = "ipl_matches_censored.json";
        string csvOutputPath = "ipl_matches_censored.csv";

        // Process JSON
        if (File.Exists(jsonInputPath))
        {
            Console.WriteLine("Processing JSON...");
            string jsonData = File.ReadAllText(jsonInputPath);
            var matches = JsonConvert.DeserializeObject<List<Match>>(jsonData);

            if (matches != null)
            {
                foreach (var match in matches)
                {
                    match.ApplyCensorship();
                }

                File.WriteAllText(jsonOutputPath, JsonConvert.SerializeObject(matches, Formatting.Indented));
                Console.WriteLine("✅ Censored JSON saved!");
            }
            else
            {
                Console.WriteLine("⚠️ JSON file is empty or invalid.");
            }
        }

        // Process CSV
        if (File.Exists(csvInputPath))
        {
            Console.WriteLine("Processing CSV...");
            using (var reader = new StreamReader(csvInputPath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null, // Ignore header mismatches
                MissingFieldFound = null // Ignore missing fields
            }))
            {
                var matches = csv.GetRecords<Match>().ToList();

                foreach (var match in matches)
                {
                    match.ApplyCensorship();
                }

                using (var writer = new StreamWriter(csvOutputPath))
                using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csvWriter.WriteRecords(matches);
                }
                Console.WriteLine("✅ Censored CSV saved!");
            }
        }
    }
}

// Match Class
public class Match
{
    [Name("match_id")]
    public int Match_Id { get; set; }

    [Name("team1")]
    public string Team1 { get; set; }

    [Name("team2")]
    public string Team2 { get; set; }

    [Name("score_team1")]
    public int Score_Team1 { get; set; }

    [Name("score_team2")]
    public int Score_Team2 { get; set; }

    [Name("winner")]
    public string Winner { get; set; }

    [Name("player_of_match")]
    public string Player_Of_Match { get; set; }

    // Apply Censorship Rules
    public void ApplyCensorship()
    {
        Team1 = MaskTeamName(Team1);
        Team2 = MaskTeamName(Team2);
        Winner = MaskTeamName(Winner);
        Player_Of_Match = "REDACTED";
    }

    // Mask Team Name Function
    private string MaskTeamName(string teamName)
    {
        var words = teamName.Split(' ');
        if (words.Length > 1)
            words[1] = "***"; // Mask second word
        return string.Join(" ", words);
    }
}