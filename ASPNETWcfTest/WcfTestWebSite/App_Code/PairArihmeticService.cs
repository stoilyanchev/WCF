using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


public class PairArihmeticService : IPairArihmeticService
{
    Pair IPairArihmeticService.Add(Pair p1, Pair p2)
    {
        Pair result = new Pair();

        result.First = p1.First + p2.First;
        result.Second = p1.Second + p2.Second;

        return result;
    }

    Pair IPairArihmeticService.Subtract(Pair p1, Pair p2)
    {
        Pair result = new Pair();

        result.First = p1.First - p2.First;
        result.Second = p1.Second - p2.Second;

        return result;
    }
}
