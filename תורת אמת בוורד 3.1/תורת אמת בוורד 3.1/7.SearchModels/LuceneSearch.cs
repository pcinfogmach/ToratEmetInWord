﻿using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using תורת_אמת_בוורד_3._1;
using תורת_אמת_בוורד_3._1._2.ViewModels;
using תורת_אמת_בוורד_3._1._8.Extensions;
using תורת_אמת_בוורד_3._1.Properties;

namespace TextSearchApp.SearchModels
{
    public class LuceneSearch: LuceneIntializer, IDisposable
    {
        FSDirectory directory;
        IndexReader reader;
        IndexSearcher searcher;
        WildcardQuery wildcardQuery;
        Sort sort;
        TopDocs topDocs;
        bool creatingIndex;

        string searchTerm;
        public void Dispose()
        {
            reader.Dispose();
            searcher.Dispose();
            directory.Dispose();
        }
        public LuceneSearch(SearchControlViewModel viewModel) : base(viewModel)
        {
            
        }

        public async Task ExecuteSearch(string searchterm)
        {
            if (Settings.Default.BusyIndexing == true) { MessageBox.Show("המערכת זיהתה שהתחלתם פעולת אינדוקס אנא השלימו פעולה זו"); }
            else if (IndexExists())
            {
                try
                {
                    await Task.Run(() =>
                    {
                        sort = new Sort(new SortField("DocNumber", SortField.INT)); // Sort by file order as an integer
                        resultsDictionary = new Dictionary<string, List<string>>();
                        using (directory = FSDirectory.Open(new DirectoryInfo(GlobalsX.indexFolder)))
                        using (reader = IndexReader.Open(directory, readOnly: true))
                        using (searcher = new IndexSearcher(reader))
                        {
                            this.searchTerm = searchterm;
                            string[] searchWords = searchTerm.Split(' ');
                            foreach (string word in searchWords)
                            {
                                Term term = new Term("CleanSnippet", word);
                                wildcardQuery = new WildcardQuery(term);
                                topDocs = searcher.Search(wildcardQuery, null, int.MaxValue, sort);
                            }
                            processResults();
                        }
                    });

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("כדי להשתמש בתכונה זו יש ליצור אינדקס באפשרויות התוכנה");
            }
        }

        void processResults()
        {
            viewModel.MaxProgress = topDocs.ScoreDocs.Length;
            string searchPattern = searchTerm.ModifyRegexPattern();
            List<string> resultList = new List<string>();
            foreach (ScoreDoc scoreDoc in topDocs.ScoreDocs)
            {
                viewModel.UpdateProgressBar(1);
                Document resultDoc = searcher.Doc(scoreDoc.Doc);
                string filePath = resultDoc.Get("FilePath");
                string content = resultDoc.Get("Snippet");
                string header = resultDoc.Get("HeaderId");

                if (filesList.Contains(filePath))
                {

                    MatchCollection matches = Regex.Matches(content, searchPattern);
                    if (matches.Count > 0)
                    {
                        foreach (Match match in matches)
                        {
                            string markedValue = $"<span style=\"color:magenta\">{match.Value}</span>";
                            content = content.Replace(match.Value, markedValue);
                        }
                        resultList.Add(ResultItem(filePath, content, header));
                    }
                }
            }
            resultsDictionary.Add("", resultList);
        }
    }
}
