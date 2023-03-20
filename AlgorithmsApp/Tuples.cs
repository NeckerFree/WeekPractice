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
            bool foundDomino=true;
            bool canChain = false;
            if (dominoes.Any() == false) return true;
            var dominoesList= dominoes.OrderByDescending(elem=> (elem.Item1, elem.Item2)).ToList();
            var sortedDominoes = new List<(int, int)>();
            var first = dominoesList.First();
            dominoesList.Remove(first);
            sortedDominoes.Add(first);
            while (dominoesList.Count() > 0 && (foundDomino == true))
            {
                foundDomino = false;
                var rightValue = sortedDominoes.Last().Item2;
                var pairSame=dominoesList.Where(item=> item.Item1 == rightValue && item.Item2==rightValue).FirstOrDefault();
                if (pairSame != (0, 0))
                {
                    sortedDominoes.Add(pairSame);
                    foundDomino = true;
                    dominoesList.Remove(pairSame);
                }
                else
                {
                    var dominoToRight = dominoesList.Where(item => item.Item1 == rightValue).FirstOrDefault();
                    if (dominoToRight != (0, 0))
                    {
                        sortedDominoes.Add(dominoToRight);
                        foundDomino = true;
                        dominoesList.Remove(dominoToRight);
                    }
                    else
                    {
                        var dominoToTurn = dominoesList.Where(item => item.Item2 == rightValue).FirstOrDefault();
                        if (dominoToTurn != (0, 0))
                        {
                            (int, int) reverse = (dominoToTurn.Item2, dominoToTurn.Item1);
                            sortedDominoes.Add(reverse);
                            foundDomino = true;
                            dominoesList.Remove(dominoToTurn);

                        }

                    }
                }
                var leftValue = sortedDominoes.First().Item1;
                pairSame = dominoesList.Where(item => item.Item1 == leftValue && item.Item2 == leftValue).FirstOrDefault();
                if (pairSame != (0, 0))
                {
                    sortedDominoes.Insert(0,pairSame);
                    foundDomino = true;
                    dominoesList.Remove(pairSame);
                }
                else
                {
                    var dominoToleft = dominoesList.Where(item => item.Item2 == leftValue).FirstOrDefault();
                    if (dominoToleft != (0, 0))
                    {
                        sortedDominoes.Insert(0, dominoToleft);
                        foundDomino = true;
                        dominoesList.Remove(dominoToleft);
                    }
                    else
                    {
                        var dominoToTurn = dominoesList.Where(item => item.Item1 == leftValue).FirstOrDefault();
                        if (dominoToTurn != (0, 0))
                        {
                            (int, int) reverse = (dominoToTurn.Item2, dominoToTurn.Item1);
                            sortedDominoes.Insert(0, reverse);
                            foundDomino = true;
                            dominoesList.Remove(dominoToTurn);

                        }

                    }
                }
            }
            if (foundDomino == true)
            {
                first = sortedDominoes.First();
                var last = sortedDominoes.Last();
                canChain = (first.Item1 == last.Item2);
            }
            else
            {
                canChain= false;
            }
            return canChain;
        }

    }
}
