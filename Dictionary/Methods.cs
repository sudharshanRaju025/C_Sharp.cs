using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dictionary
{
    class Methods
    {
        public void Add()
        {
            Dictionary<string, int> names = new Dictionary<string, int>();

            names.Add("sudharshan", 34);
            names.Add("lakshmidhar", 35);
            names.Add("mahendra", 78);

            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
        }

        public void keyGetting()
        {
            //Dictionary<string, int> names = new Dictionary<string, int>();

            //names.Add("sudharshan", 34);
            //names.Add("lakshmidhar", 35);
            //names.Add("mahendra", 78);

            //foreach (var i in names)
            //{
            //    if (i.Key == "sudharshan")
            //    {
            //        Console.WriteLine(true);
            //    }

            //}
        }

        public void StringMethod(string query)
        {
            string Query = query.ToLower();
            if (Query.Contains("vacancies") && Query.Contains("56") && query.Contains("more than"))
            {
                var data = new Dictionary<string, List<object>>
                {
                    { "names", new List<object> { "sudharshan", 56 } }
                };
                data.Add("details", ["kondurur", 78]);

                foreach (var i in data)
                {
                    string key = i.Key;
                    object secondvalue = i.Value[1];
                    Console.WriteLine($"{key} - {secondvalue}");
                }

                //foreach (var kvp in data)
                //{
                //    string key = kvp.Key;
                //    object secondValue = kvp.Value.Count > 1 ? kvp.Value[1] : null;

                //    if (secondValue != null)
                //    {
                //        string result = $"{key}-{secondValue}";
                //        Console.WriteLine(result); // Output: names-56
                //    }
                //}
            }

        }

        public void Method(string input)
        {

            //string query = "find all companies in New York";
            //string query = "find all companies in New York";

            //string[] words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //var wordMap = new Dictionary<string, string>();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    wordMap[$"word{i + 1}"] = words[i];
            //}

            //// Example: print the result
            //foreach (var kvp in wordMap)
            //{
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            //}



            //Dictionary<string, List<object>> Names = new Dictionary<string, List<object>>();

            //Names.Add("sudha", ["sv university", 98]);
            //Names.Add("sinchan", ["narayana", 99]);
            //Names.Add("sandy", ["chaitanya", 95]);

            //foreach(var i in Names)
            //{
            //    Console.WriteLine($"{i.Key}-{i.Value[0]}");
            //}

            //var QUERY = query.Trim();
            //    if (query.StartsWith("more than"))
            //    {
            //        if (query.Contains("vacancies") && query.Contains("more than") || query.Contains("less than"))
            //        {
            //            Names.Add("vacancies", []);
            //        }
            //        if(Names.ContainsKey("vacancies"))
            //        {
            //            Names["vacanices"] = ["more than",0];
            //        }

            //    }




            // Split query into parts based on keywords

            if (string.IsNullOrWhiteSpace(input))
            
                Console.WriteLine(string.Empty);
            

            // Define known job roles
            string[] knownJobRoles = { "Developer", "Analyst", "Tester", "Researcher", "Designer", "Coordinator", "Architect", "HR" };

            string[] separators = { "and", "which", "wherever", "those are" };
            string pattern = @"\b(" + string.Join("|", separators.Select(Regex.Escape)) + @")\b";

            var parts = Regex.Split(input, pattern, RegexOptions.IgnoreCase)
                             .Where(p => !separators.Contains(p.Trim(), StringComparer.OrdinalIgnoreCase))
                             .Select(p => p.Trim())
                             .Where(p => !string.IsNullOrWhiteSpace(p))
                             .ToList();

            List<string> conditions = new List<string>();

            foreach (var part in parts)
            {
                var condition = ParseConditionPart(part);
                if (!string.IsNullOrEmpty(condition))
                {
                    conditions.Add(condition);
                }
            }

            // Add Job_roles matching if any known roles are present in the input
            var remainingWords = Regex.Split(input, @"[\s,\.]+")
                                      .Where(w => !string.IsNullOrWhiteSpace(w))
                                      .Select(w => w.Trim())
                                      .Distinct(StringComparer.OrdinalIgnoreCase)
                                      .ToList();

            List<string> jobRoleMatches = new List<string>();

            foreach (var word in remainingWords)
            {
                if (knownJobRoles.Contains(word, StringComparer.OrdinalIgnoreCase))
                {
                    jobRoleMatches.Add($"Job_roles.Contains(\"{word}\")");
                }
            }

            if (jobRoleMatches.Count > 0)
            {
                conditions.Add("(" + string.Join(" OR ", jobRoleMatches) + ")");
            }

           string final_query= string.Join(" AND ", conditions);

            Console.WriteLine( $"{final_query}");



            static string ParseConditionPart(string part)
                {
                    string[] words = part.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    // Get country names
                    HashSet<string> countryNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                    foreach (var culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                    {
                        try
                        {
                            RegionInfo region = new RegionInfo(culture.Name);
                            countryNames.Add(region.EnglishName);
                        }
                        catch { }
                    }

                    string[] startWords = { "Vacancies", "Job_roles", "Need_Factor", "Location", "Vacancy_Factor", "Name", "name" };
                    string[] endwords = { "Developer", "Analyst", "Tester", "HR", "Researcher", "Designer", "Coordinator", "Architect" };

                    int startIndex = -1;
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (startWords.Contains(words[i], StringComparer.OrdinalIgnoreCase))
                        {
                            startIndex = i;
                            break;
                        }
                    }

                    int endIndex = -1;
                    for (int i = startIndex + 1; i < words.Length; i++)
                    {
                        if (int.TryParse(words[i], out _) ||
                            countryNames.Contains(words[i], StringComparer.OrdinalIgnoreCase) ||
                            new[] { "yearly", "half-yearly", "weekly", "monthly" }
                                .Contains(words[i], StringComparer.OrdinalIgnoreCase) ||
                            endwords.Contains(words[i], StringComparer.OrdinalIgnoreCase))
                        {
                            endIndex = i;
                            break;
                        }
                    }

                    if (startIndex != -1 && endIndex != -1 && endIndex >= startIndex)
                    {
                        string[] trimmedWords = words.Skip(startIndex).Take(endIndex - startIndex + 1).ToArray();
                        var dict = new Dictionary<string, List<string>>();

                        if (trimmedWords.Length >= 4)
                        {
                            string key = trimmedWords[0];
                            string combined1 = $"{trimmedWords[1]} {trimmedWords[2]}";
                            string combined2 = trimmedWords[3];
                            dict[key] = new List<string> { combined1, combined2 };
                        }
                        else
                        {
                            string key = trimmedWords[0];
                            List<string> values = trimmedWords.Skip(1).ToList();
                            dict[key] = values;
                        }

                        return ConvertToCondition(dict);
                    }

                    return string.Empty;
                }

                static string ConvertToCondition(Dictionary<string, List<string>> dict)
                {
                    foreach (var kvp in dict)
                    {
                        string key = kvp.Key;
                        List<string> values = kvp.Value;

                        if (values.Count == 2)
                        {
                            string operation = values[0].ToLower();
                            string operand = values[1];

                            bool IsNumeric(string val) => double.TryParse(val, out _);
                            bool IsBoolean(string val) => val.Equals("true", StringComparison.OrdinalIgnoreCase) || val.Equals("false", StringComparison.OrdinalIgnoreCase);
                            string FormatValue(string val) => IsNumeric(val) || IsBoolean(val) ? val : $"\"{val}\"";

                            return operation switch
                            {
                                "present in" => $"{key} == {FormatValue(operand)}",
                                "more than" => $"{key} > {FormatValue(operand)}",
                                "less than" => $"{key} < {FormatValue(operand)}",
                                "except" => $"{key} != {FormatValue(operand)}",
                                "not present in" => $"{key} != {FormatValue(operand)}",
                                "like" => $"{key}.Contains({FormatValue(operand)})",
                                "with" => $"{key}.Contains({FormatValue(operand)})",
                                "likely" => $"{key}.Contains({FormatValue(operand)})",
                                "exactly" => $"{key} == {FormatValue(operand)}",
                                "exact" => $"{key} == {FormatValue(operand)}",
                                _ => $"{key} == {FormatValue(operand)}"
                            };
                        }
                        else if (values.Count == 1)
                        {
                            return $"{kvp.Key}.Contains(\"{values[0]}\")";
                        }
                    }
                    return string.Empty;
                }
            }
        }
    


}

