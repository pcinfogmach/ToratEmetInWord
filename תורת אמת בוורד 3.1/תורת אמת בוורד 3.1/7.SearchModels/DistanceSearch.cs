﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using תורת_אמת_בוורד_3._1._2.ViewModels;

namespace TextSearchApp.SearchModels
{
    public class DistanceSearch : SearchMethods
    {
        public DistanceSearch(SearchControlViewModel viewModel) : base(viewModel) { }
        public async Task SearchAsync(string searchPattern)
        {
            resultsDictionary = new Dictionary<string, List<string>>();
            string[] searchPatternArray = searchPattern.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Task> searchTasks = new List<Task>();
            foreach (string filePath in filesList)
            { 
                resultsDictionary.Add(filePath, new List<string>());
                searchTasks.Add(Task.Run(() => { processFile(filePath, searchPatternArray, searchPattern); }));
            }
            await Task.WhenAll(searchTasks);
            
        }
        void processFile(string filePath, string[] searchPatternArray, string searchPattern)
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
                    //else if (searchPatternArray.All(word => line.Contains(word)))
                    else if (line.StringContains(searchPatternArray, searchPattern.Length))
                    {
                        line = CleanContent(line);
                        for (int i = 0; i < searchPatternArray.Length; i++)
                        {
                            line = line.Replace(searchPatternArray[i], $"<span style=\"color:magenta\">{searchPatternArray[i]}</span>");
                        }
                        currentReslutList.Add(ResultItem(filePath, line, currentHeader));
                    }


                }
            }
            resultsDictionary[filePath] = currentReslutList;
        }
    }
}
