using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListHashSetDictionaryBenchmark
{
    class Program
    {

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Benchmark>();
        }

    }
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net472)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [MarkdownExporter]
    public class Benchmark
    {
        private int timesToAdd = 1000000;
        private string[] dataGuid;
        private List<string> guidToLookup;

        private List<string> _listLookupTestUse;
        private HashSet<string> _hashSetLookupTestUse;
        private Dictionary<string, bool> _dictLookupTestUse;
        public Benchmark()
        {
            dataGuid = new string[timesToAdd];
            for (int i = 0; i < timesToAdd; i++)
            {
                dataGuid[i] = Guid.NewGuid().ToString();
            }
            _listLookupTestUse = new List<string>();
            _hashSetLookupTestUse = new HashSet<string>();
            _dictLookupTestUse = new Dictionary<string, bool>();
            foreach (var str in dataGuid)
            {
                _listLookupTestUse.Add(str);
                _hashSetLookupTestUse.Add(str);
                _dictLookupTestUse.Add(str, true);
            }
            guidToLookup = new List<string>() { dataGuid[(int)(timesToAdd / 2)], dataGuid[(int)(timesToAdd / 4)], dataGuid[(int)(timesToAdd / 6)], dataGuid[(int)(timesToAdd / 8)], dataGuid[(int)(timesToAdd / 10)], dataGuid[(int)(timesToAdd / 12)], dataGuid[(int)(timesToAdd / 14)], dataGuid[(int)(timesToAdd / 16)], dataGuid[(int)(timesToAdd / 20)], dataGuid[(int)(timesToAdd / 22)], dataGuid[(int)(timesToAdd / 26)], dataGuid[(int)(timesToAdd / 30)] };
        }
        [Benchmark]
        public void ListAdd()
        {
            var list = new List<string>();
            foreach (var str in dataGuid)
            {
                list.Add(str);
            }
        }
        [Benchmark]
        public void ListFind()
        {

            foreach (var guid in guidToLookup)
            {
                _listLookupTestUse.Where(x => x == guid);
            }
        }
        [Benchmark]
        public void HashSetAdd()
        {
            var hashSet = new HashSet<string>();
            foreach (var str in dataGuid)
            {
                hashSet.Add(str);
            }
        }
        [Benchmark]
        public void HashSetFind()
        {

            foreach (var guid in guidToLookup)
            {
                _hashSetLookupTestUse.Contains(guid);
            }
        }
        [Benchmark]
        public void DictionaryAdd()
        {
            var dict = new Dictionary<string, bool>();
            foreach (var str in dataGuid)
            {
                dict.Add(str, true);
            }
        }
        [Benchmark]
        public void DictFind()
        {

            foreach (var guid in guidToLookup)
            {
                _dictLookupTestUse.ContainsKey(guid);
            }
        }
    }
}
