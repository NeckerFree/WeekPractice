using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsApp
{
    public class Tuples
    {
        public static bool CanChain(IEnumerable<(int, int)> dominoes)
        {
            bool canChain = false;
            if (dominoes.Any() == false) return canChain;
            var dominoesResult = new List<(int, int)>();
            dominoes = dominoes.OrderBy(item =>(item.Item1, item.Item2));
            foreach (var domino in dominoes)
            {
                bool dominoInlist = dominoesResult.Contains(domino);
                int index = -1;
                var dominoToProcess = (dominoInlist == false) ? domino: (domino.Item2, domino.Item1) ;
                index = GetIndex(dominoesResult, dominoToProcess);
                if (index == dominoesResult.Count)
                {
                    if (dominoToProcess == domino)
                    {
                        var dominoReverse = (domino.Item2, domino.Item1);
                        var newindex = GetIndex(dominoesResult, dominoReverse);
                        index = (newindex == dominoesResult.Count) ? index : newindex;
                        dominoToProcess = (newindex == dominoesResult.Count) ? domino : dominoReverse;
                    }
                }
                if (index == 0 && dominoesResult.Count>0)
                {
                    if (dominoesResult[index].Item1 == dominoToProcess.Item1)
                    {
                        var dominoReverse = (domino.Item2, domino.Item1);
                        dominoToProcess = dominoReverse;
                    }
                }
                dominoesResult.Insert(index, dominoToProcess);

            }

            var first = dominoesResult.First();
            var last = dominoesResult.Last();
            canChain = (first.Item1 == last.Item2);
            return canChain;
        }

        private static int GetIndex(List<(int, int)> dominoesResult, (int, int) domino)
        {
            var nextDomino = dominoesResult.Where(elem => elem.Item2 == domino.Item1).FirstOrDefault();
            int index = dominoesResult.IndexOf(nextDomino);
            if (index != -1)
            {
                if (index != 0)
                {
                    var previous = dominoesResult[index - 1];
                    if (previous.Item2 == nextDomino.Item1)
                    {
                        index = dominoesResult.Count;
                    }
                }
                //else
                //{
                //    index = 1;
                //}
            }
            else
            {
                (int, int) reverse = (domino.Item2, domino.Item1);
                var foundReverse = dominoesResult.Where(elem => elem.Item2 == reverse.Item1).FirstOrDefault();
                int indexReverse = dominoesResult.IndexOf(foundReverse);
                if (indexReverse != -1)
                {
                    var previous = dominoesResult[indexReverse - 1];
                    if (previous.Item2 == foundReverse.Item1)
                    {
                        index = dominoesResult.Count;
                    }
                }
                else
                {
                    index = dominoesResult.Count;
                }

            }

            return index;
        }
    }
}
