﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using תורת_אמת_בוורד_3._1._2.ViewModels;
using תורת_אמת_בוורד_3._1._8.Extensions;

namespace TextSearchApp
{
    public class RegexSearch : SearchMethods
    {
        bool ignoreTags;
        public RegexSearch(SearchControlViewModel viewModel, bool ignoretags ) : base(viewModel) 
        {
            ignoreTags = ignoretags;
        }
        public async Task SearchAsync(string searchPattern)
        {
            resultsDictionary = new Dictionary<string, List<string>>();
            if (ignoreTags) 
            {
                searchPattern = searchPattern.ModifyRegexPattern();
            }

            List<Task> searchTasks = new List<Task>();
            foreach (string filePath in filesList)
            {
                resultsDictionary.Add(filePath, new List<string>());
                searchTasks.Add(Task.Run(() => { processFile(filePath, searchPattern); }));
            }
            await Task.WhenAll(searchTasks);
            
        }
        void processFile(string filePath, string searchPattern)
        {
            ProcessHeaders processHeaders = new ProcessHeaders();
            string currentHeader = "";
            viewModel.UpdateProgressBar(1);
            List<string> currentReslutList = new List<string>();

            using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(1255)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (startChars.Any(c => line.StartsWith(c)))
                    {
                        currentHeader = processHeaders.Execute(line, filePath);
                        continue;
                    }
                    else if (Regex.IsMatch(line, searchPattern))
                    {
                        line = CleanContent(line);
                        MatchCollection matches = Regex.Matches(line, searchPattern);
                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches)
                            {
                                string markedValue = $"<span style=\"color:magenta\">{match.Value}</span>";
                                line = line.Replace(match.Value, markedValue);
                            }
                        }
                        currentReslutList.Add(ResultItem(filePath, line, currentHeader));
                    }
                }
            }
            resultsDictionary[filePath] = currentReslutList;
        }
    }
}
